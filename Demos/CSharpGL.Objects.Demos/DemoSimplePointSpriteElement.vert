﻿#version 150 core

in vec3 in_Position;

uniform mat4 MVP;
uniform float pointSize;
uniform float foreshortening;

void main(void) 
{
	vec4 pos = MVP * vec4(in_Position, 1.0);
	gl_Position = pos;
	if (foreshortening == 1.0f)
	{
		gl_PointSize = (1.0 - pos.z * 500 / pos.w) * pointSize;// 500: scale factor, 64.0: size factor
	}
	else
	{
		gl_PointSize = pointSize;
	}
}
