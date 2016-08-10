using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUIStyleState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GUIStyleState o;
			o=new UnityEngine.GUIStyleState();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_background(IntPtr l) {
		try {
			UnityEngine.GUIStyleState self=(UnityEngine.GUIStyleState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.background);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_background(IntPtr l) {
		try {
			UnityEngine.GUIStyleState self=(UnityEngine.GUIStyleState)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.background=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textColor(IntPtr l) {
		try {
			UnityEngine.GUIStyleState self=(UnityEngine.GUIStyleState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textColor(IntPtr l) {
		try {
			UnityEngine.GUIStyleState self=(UnityEngine.GUIStyleState)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.textColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUIStyleState");
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"textColor",get_textColor,set_textColor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUIStyleState));
	}
}
