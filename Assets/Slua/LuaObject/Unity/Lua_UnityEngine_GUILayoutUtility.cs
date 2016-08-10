using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUILayoutUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GUILayoutUtility o;
			o=new UnityEngine.GUILayoutUtility();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BeginGroup_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GUILayoutUtility.BeginGroup(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EndGroup_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GUILayoutUtility.EndGroup(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRect_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GUIContent),typeof(UnityEngine.GUIStyle))){
				UnityEngine.GUIContent a1;
				checkType(l,1,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(UnityEngine.GUILayoutOption[]))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,3,out a3);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(UnityEngine.GUIStyle))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.GUIStyle a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GUIContent),typeof(UnityEngine.GUIStyle),typeof(UnityEngine.GUILayoutOption[]))){
				UnityEngine.GUIContent a1;
				checkType(l,1,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,2,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,3,out a3);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(UnityEngine.GUIStyle),typeof(UnityEngine.GUILayoutOption[]))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.GUIStyle a3;
				checkType(l,3,out a3);
				UnityEngine.GUILayoutOption[] a4;
				checkParams(l,4,out a4);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float),typeof(float),typeof(UnityEngine.GUILayoutOption[]))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GUILayoutOption[] a5;
				checkParams(l,5,out a5);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float),typeof(float),typeof(UnityEngine.GUIStyle))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GUIStyle a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.GUIStyle a5;
				checkType(l,5,out a5);
				UnityEngine.GUILayoutOption[] a6;
				checkParams(l,6,out a6);
				var ret=UnityEngine.GUILayoutUtility.GetRect(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLastRect_s(IntPtr l) {
		try {
			var ret=UnityEngine.GUILayoutUtility.GetLastRect();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAspectRect_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Single a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.GUILayoutUtility.GetAspectRect(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.GUILayoutOption[]))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.GUILayoutOption[] a2;
				checkParams(l,2,out a2);
				var ret=UnityEngine.GUILayoutUtility.GetAspectRect(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.GUIStyle))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.GUILayoutUtility.GetAspectRect(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.GUIStyle a2;
				checkType(l,2,out a2);
				UnityEngine.GUILayoutOption[] a3;
				checkParams(l,3,out a3);
				var ret=UnityEngine.GUILayoutUtility.GetAspectRect(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUILayoutUtility");
		addMember(l,BeginGroup_s);
		addMember(l,EndGroup_s);
		addMember(l,GetRect_s);
		addMember(l,GetLastRect_s);
		addMember(l,GetAspectRect_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUILayoutUtility));
	}
}
