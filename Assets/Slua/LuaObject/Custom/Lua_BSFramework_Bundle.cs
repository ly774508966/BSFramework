using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BSFramework_Bundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			BSFramework.Bundle o;
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			o=new BSFramework.Bundle(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			var ret=self.Load();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnLoad(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			self.UnLoad();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetAsync(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAssetAsync(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_md5(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.md5);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_md5(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.md5=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_path(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_path(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IsLoaded(IntPtr l) {
		try {
			BSFramework.Bundle self=(BSFramework.Bundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsLoaded);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BSFramework.Bundle");
		addMember(l,Load);
		addMember(l,UnLoad);
		addMember(l,LoadAssetAsync);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"md5",get_md5,set_md5,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"IsLoaded",get_IsLoaded,null,true);
		createTypeMetatable(l,constructor, typeof(BSFramework.Bundle));
	}
}
