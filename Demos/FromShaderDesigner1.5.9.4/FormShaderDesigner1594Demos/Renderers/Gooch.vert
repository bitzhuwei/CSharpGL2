﻿//
// Vertex shader for Gooch shading
//
// Author: Randi Rost
//
// Copyright (c) 2002-2004 3Dlabs Inc. Ltd.
//
// See 3Dlabs-License.txt for license information
//

#version 150 core
 
in vec3 in_Position;
in vec3 in_Normal;
out float NdotL;
out vec3  ReflectVec;
out vec3  ViewVec;

uniform mat4 modelMatrix;
uniform mat4 viewMatrix;
uniform mat4 projectionMatrix;
uniform vec3  lightPosition;  // (0.0, 10.0, 4.0) 

void main(void)
{
    vec3 ecPos      = vec3 (viewMatrix * modelMatrix * vec4(in_Position, 1.0));
    vec3 tnorm      = normalize(vec3(viewMatrix * modelMatrix * vec4(in_Normal, 1.0)));
    vec3 lightVec   = normalize(lightPosition - ecPos);
    ReflectVec      = normalize(reflect(-lightVec, tnorm));
    ViewVec         = normalize(-ecPos);
    NdotL           = (dot(lightVec, tnorm) + 1.0) * 0.5;
    gl_Position     = projectionMatrix * vec4(ecPos, 1.0);
}
