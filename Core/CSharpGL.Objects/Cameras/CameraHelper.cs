﻿using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL.Objects.Cameras
{
    /// <summary>
    /// TODO:摄像机的perspective和ortho视角，是否应该同时变化？
    /// </summary>
    public static class CameraHelper
    {
        ///// <summary>
        ///// Adjusts camera's settings according to bounding box.
        ///// <para>Use this when bounding box's size or positon is changed.</para>
        ///// </summary>
        ///// <param name="camera"></param>
        ///// <param name="boundingBox"></param>
        //public static void ZoomCamera(this IScientificCamera camera, IBoundingBox boundingBox)
        //{
        //    float sizeX, sizeY, sizeZ;
        //    boundingBox.GetBoundDimensions(out sizeX, out sizeY, out sizeZ);
        //    float size = Math.Max(Math.Max(sizeX, sizeY), sizeZ);

        //    {
        //        float centerX, centerY, centerZ;
        //        boundingBox.GetCenter(out centerX, out centerY, out centerZ);
        //        vec3 target = new vec3(centerX, centerY, centerZ);

        //        vec3 target2Position = camera.Position - camera.Target;
        //        target2Position.Normalize();

        //        vec3 position = target + target2Position * (size * 2 + 1);

        //        camera.Position = position;
        //        camera.Target = target;
        //        //camera.UpVector = new vec3(0f, 1f, 0f);
        //    }

        //    {
        //        int[] viewport = new int[4];
        //        GL.GetInteger(GetTarget.Viewport, viewport);
        //        int width = viewport[2]; int height = viewport[3];

        //        IPerspectiveViewCamera perspectiveViewCamera = camera;
        //        perspectiveViewCamera.FieldOfView = 60;
        //        perspectiveViewCamera.AspectRatio = (double)width / (double)height;
        //        perspectiveViewCamera.Near = 0.01;
        //        perspectiveViewCamera.Far = size * 3 + 1;// double.MaxValue;
        //    }
        //    {
        //        int[] viewport = new int[4];
        //        GL.GetInteger(GetTarget.Viewport, viewport);
        //        int width = viewport[2]; int height = viewport[3];

        //        IOrthoViewCamera orthoViewCamera = camera;
        //        if (width > height)
        //        {
        //            orthoViewCamera.Left = -size * width / height;
        //            orthoViewCamera.Right = size * width / height;
        //            orthoViewCamera.Bottom = -size;
        //            orthoViewCamera.Top = size;
        //        }
        //        else
        //        {
        //            orthoViewCamera.Left = -size;
        //            orthoViewCamera.Right = size;
        //            orthoViewCamera.Bottom = -size * height / width;
        //            orthoViewCamera.Top = size * height / width;
        //        }
        //        orthoViewCamera.Near = 0;
        //        orthoViewCamera.Far = size * 3 + 1;// double.MaxValue;
        //    }
        //}

        /// <summary>
        /// Adjusts camera's settings according to bounding box.
        /// <para>Use this when bounding box's size or positon is changed.</para>
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="boundingBox"></param>
        public static void ZoomCamera(this IPerspectiveViewCamera camera, IBoundingBox boundingBox)
        {
            float sizeX, sizeY, sizeZ;
            boundingBox.GetBoundDimensions(out sizeX, out sizeY, out sizeZ);
            float size = Math.Max(Math.Max(sizeX, sizeY), sizeZ);

            {
                float centerX, centerY, centerZ;
                boundingBox.GetCenter(out centerX, out centerY, out centerZ);
                vec3 target = new vec3(centerX, centerY, centerZ);

                vec3 target2Position = (camera.Position - camera.Target).normalize();

                vec3 position = target + target2Position * (size * 2 + 1);

                camera.Position = position;
                camera.Target = target;
                //camera.UpVector = new vec3(0f, 1f, 0f);
            }

            {
                int[] viewport = new int[4];
                GL.GetInteger(GetTarget.Viewport, viewport);
                int width = viewport[2]; int height = viewport[3];

                camera.FieldOfView = 60;
                camera.AspectRatio = (double)width / (double)height;
                camera.Near = 0.01;
                camera.Far = size * 3 + 1;// double.MaxValue;
            }
        }

        /// <summary>
        /// Adjusts camera's settings according to bounding box.
        /// <para>Use this when bounding box's size or positon is changed.</para>
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="boundingBox"></param>
        public static void ZoomCamera(this IOrthoViewCamera camera, IBoundingBox boundingBox)
        {
            float sizeX, sizeY, sizeZ;
            boundingBox.GetBoundDimensions(out sizeX, out sizeY, out sizeZ);
            float size = Math.Max(Math.Max(sizeX, sizeY), sizeZ);

            {
                float centerX, centerY, centerZ;
                boundingBox.GetCenter(out centerX, out centerY, out centerZ);
                vec3 target = new vec3(centerX, centerY, centerZ);

                vec3 target2Position = (camera.Position - camera.Target).normalize();

                vec3 position = target + target2Position * (size * 2 + 1);

                camera.Position = position;
                camera.Target = target;
                //camera.UpVector = new vec3(0f, 1f, 0f);
            }

            {
                int[] viewport = new int[4];
                GL.GetInteger(GetTarget.Viewport, viewport);
                int width = viewport[2]; int height = viewport[3];

                if (width > height)
                {
                    camera.Left = -size * width / height;
                    camera.Right = size * width / height;
                    camera.Bottom = -size;
                    camera.Top = size;
                }
                else
                {
                    camera.Left = -size;
                    camera.Right = size;
                    camera.Bottom = -size * height / width;
                    camera.Top = size * height / width;
                }
                camera.Near = 0;
                camera.Far = size * 3 + 1;// double.MaxValue;
            }
        }

        /// <summary>
        /// Apply specifed viewType to camera according to bounding box's size and position.
        /// <para>    +-------+    </para>
        /// <para>   /|      /|    </para>
        /// <para>  +-------+ |    </para>
        /// <para>  | |     | |    </para>
        /// <para>  | O-----|-+---X</para>
        /// <para>  |/      |/     </para>
        /// <para>  +-------+      </para>
        /// <para> /  |            </para>
        /// <para>Y   Z            </para>
        /// <para>其边长为(2 * Math.Sqrt(3)), 所在的坐标系如下</para>
        /// <para>   O---X</para>
        /// <para>  /|    </para>
        /// <para> Y |    </para>
        /// <para>   Z    </para>
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="boundingBox"></param>
        /// <param name="viewType"></param>
        public static void ApplyViewType(this IPerspectiveViewCamera camera, IBoundingBox boundingBox,
            ViewTypes viewType)
        {
            float sizeX, sizeY, sizeZ;
            boundingBox.GetBoundDimensions(out sizeX, out sizeY, out sizeZ);
            float size = Math.Max(Math.Max(sizeX, sizeY), sizeZ);

            {
                float centerX, centerY, centerZ;
                boundingBox.GetCenter(out centerX, out centerY, out centerZ);
                vec3 target = new vec3(centerX, centerY, centerZ);

                vec3 target2Position;
                vec3 upVector;
                GetBackAndUp(out target2Position, out upVector, viewType);

                vec3 position = target + target2Position * (size * 2 + 1);

                camera.Position = position;
                camera.Target = target;
                camera.UpVector = upVector;
            }

            {
                int[] viewport = new int[4];
                GL.GetInteger(GetTarget.Viewport, viewport);
                int width = viewport[2]; int height = viewport[3];

                IPerspectiveCamera perspectiveCamera = camera;
                perspectiveCamera.FieldOfView = 60;
                perspectiveCamera.AspectRatio = (double)width / (double)height;
                perspectiveCamera.Near = 0.01;
                perspectiveCamera.Far = size * 3 + 1;// double.MaxValue;
            }
        }

        /// <summary>
        /// Apply specifed viewType to camera according to bounding box's size and position.
        /// <para>    +-------+    </para>
        /// <para>   /|      /|    </para>
        /// <para>  +-------+ |    </para>
        /// <para>  | |     | |    </para>
        /// <para>  | O-----|-+---X</para>
        /// <para>  |/      |/     </para>
        /// <para>  +-------+      </para>
        /// <para> /  |            </para>
        /// <para>Y   Z            </para>
        /// <para>其边长为(2 * Math.Sqrt(3)), 所在的坐标系如下</para>
        /// <para>   O---X</para>
        /// <para>  /|    </para>
        /// <para> Y |    </para>
        /// <para>   Z    </para>
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="boundingBox"></param>
        /// <param name="viewType"></param>
        public static void ApplyViewType(this IOrthoViewCamera camera, IBoundingBox boundingBox,
             ViewTypes viewType)
        {
            float sizeX, sizeY, sizeZ;
            boundingBox.GetBoundDimensions(out sizeX, out sizeY, out sizeZ);
            float size = Math.Max(Math.Max(sizeX, sizeY), sizeZ);

            {
                float centerX, centerY, centerZ;
                boundingBox.GetCenter(out centerX, out centerY, out centerZ);
                vec3 target = new vec3(centerX, centerY, centerZ);

                vec3 target2Position;
                vec3 upVector;
                GetBackAndUp(out target2Position, out upVector, viewType);

                vec3 position = target + target2Position * (size * 2 + 1);

                camera.Position = position;
                camera.Target = target;
                camera.UpVector = upVector;
            }

            {
                int[] viewport = new int[4];
                GL.GetInteger(GetTarget.Viewport, viewport);
                int width = viewport[2]; int height = viewport[3];

                IOrthoCamera orthoCamera = camera;
                if (width > height)
                {
                    orthoCamera.Left = -size * width / height;
                    orthoCamera.Right = size * width / height;
                    orthoCamera.Bottom = -size;
                    orthoCamera.Top = size;
                }
                else
                {
                    orthoCamera.Left = -size;
                    orthoCamera.Right = size;
                    orthoCamera.Bottom = -size * height / width;
                    orthoCamera.Top = size * height / width;
                }
                orthoCamera.Near = 0.001;
                orthoCamera.Far = size * 3 + 1;// double.MaxValue;
            }
        }

        private static void GetBackAndUp(out vec3 target2Position, out vec3 upVector, ViewTypes viewType)
        {
            switch (viewType)
            {
                case ViewTypes.UserView:
                    //UserView 定义为从顶视图开始，绕X 轴旋转30 度，在绕Z 轴45 度，并且能看到整个模型的虚拟模型空间。
                    target2Position = (new vec3((float)Math.Sqrt(3), (float)Math.Sqrt(3), -1)).normalize();
                    upVector = new vec3(0, 0, -1);
                    break;
                case ViewTypes.Top:
                    target2Position = new vec3(0, 0, -1);
                    upVector = new vec3(0, -1, 0);
                    break;
                case ViewTypes.Bottom:
                    target2Position = new vec3(0, 0, 1);
                    upVector = new vec3(0, -1, 0);
                    break;
                case ViewTypes.Left:
                    target2Position = new vec3(-1, 0, 0);
                    upVector = new vec3(0, 0, -1);
                    break;
                case ViewTypes.Right:
                    target2Position = new vec3(1, 0, 0);
                    upVector = new vec3(0, 0, -1);
                    break;
                case ViewTypes.Front:
                    target2Position = new vec3(0, 1, 0);
                    upVector = new vec3(0, 0, -1);
                    break;
                case ViewTypes.Back:
                    target2Position = new vec3(0, -1, 0);
                    upVector = new vec3(0, 0, -1);
                    break;
                default:
                    throw new NotImplementedException(string.Format("new value({0}) of EViewType is not implemented!", viewType));
                //break;
            }
        }

        
        /// <summary>
        /// 实施传统方式的投影
        /// </summary>
        /// <param name="camera"></param>
        public static void LegacyGLProjection(this ICamera camera)
        {
            //	Load the projection identity matrix.
            GL.MatrixMode(GL.GL_PROJECTION);
            GL.LoadIdentity();

            //	Perform the projection.
            switch (camera.CameraType)
            {
                case CameraType.Perspecitive:
                    IPerspectiveCamera perspectiveCamera = camera;
                    GL.gluPerspective(perspectiveCamera.FieldOfView, perspectiveCamera.AspectRatio, perspectiveCamera.Near, perspectiveCamera.Far);
                    break;
                case CameraType.Ortho:
                    IOrthoCamera orthoCamera = camera;
                    GL.Ortho(orthoCamera.Left, orthoCamera.Right, orthoCamera.Bottom, orthoCamera.Top, orthoCamera.Near, orthoCamera.Far);
                    break;
                default:
                    break;
            }

            //  Perform the look at transformation.
            GL.gluLookAt((double)camera.Position.x, (double)camera.Position.y, (double)camera.Position.z,
                (double)camera.Target.x, (double)camera.Target.y, (double)camera.Target.z,
                (double)camera.UpVector.x, (double)camera.UpVector.y, (double)camera.UpVector.z);

            //	Back to the modelview matrix.
            GL.MatrixMode(GL.GL_MODELVIEW);
        }

    }
}
