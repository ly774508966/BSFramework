﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUILayout_AreaScope : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.GUILayout.AreaScope o;
			if(argc==2){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				o=new UnityEngine.GUILayout.AreaScope(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(string))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(UnityEngine.GUIContent))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				UnityEngine.GUIContent a2;
				checkType(l,3,out a2);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(string),typeof(UnityEngine.GUIStyle))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.GUIStyle a3;
				checkType(l,4,out a3);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(UnityEngine.Texture),typeof(UnityEngine.GUIStyle))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				UnityEngine.GUIStyle a3;
				checkType(l,4,out a3);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(UnityEngine.GUIContent),typeof(UnityEngine.GUIStyle))){
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				UnityEngine.GUIContent a2;
				checkType(l,3,out a2);
				UnityEngine.GUIStyle a3;
				checkType(l,4,out a3);
				o=new UnityEngine.GUILayout.AreaScope(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUILayout.AreaScope");
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUILayout.AreaScope),typeof(UnityEngine.GUI.Scope));
	}
}
