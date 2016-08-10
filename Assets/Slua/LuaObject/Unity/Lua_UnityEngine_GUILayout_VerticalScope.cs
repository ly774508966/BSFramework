﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUILayout_VerticalScope : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.GUILayout.VerticalScope o;
			if(argc==2){
				UnityEngine.GUILayoutOption[] a1;
				checkParams(l,2,out a1);
				o=new UnityEngine.GUILayout.VerticalScope(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				UnityEngine.GUIStyle a1;
				checkType(l,2,out a1);
				UnityEngine.GUILayoutOption[] a2;
				checkParams(l,3,out a2);
				o=new UnityEngine.GUILayout.VerticalScope(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.GUIStyle),typeof(UnityEngine.GUILayoutOption[]))){
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,3,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,4,out a3);
				o=new UnityEngine.GUILayout.VerticalScope(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.GUIStyle),typeof(UnityEngine.GUILayoutOption[]))){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,3,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,4,out a3);
				o=new UnityEngine.GUILayout.VerticalScope(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.GUIContent),typeof(UnityEngine.GUIStyle),typeof(UnityEngine.GUILayoutOption[]))){
				UnityEngine.GUIContent a1;
				checkType(l,2,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,3,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,4,out a3);
				o=new UnityEngine.GUILayout.VerticalScope(a1,a2,a3);
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
		getTypeTable(l,"UnityEngine.GUILayout.VerticalScope");
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUILayout.VerticalScope),typeof(UnityEngine.GUI.Scope));
	}
}
