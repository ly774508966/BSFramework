using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BSFramework_AssetMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			BSFramework.AssetMgr o;
			o=new BSFramework.AssetMgr();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Init_s(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour a1;
			checkType(l,1,out a1);
			System.Action a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=BSFramework.AssetMgr.Init(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.AssetMgr.Load(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadScene_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.AssetMgr.LoadScene(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnLoad_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			BSFramework.AssetMgr.UnLoad(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BSFramework.AssetMgr");
		addMember(l,Init_s);
		addMember(l,Load_s);
		addMember(l,LoadScene_s);
		addMember(l,UnLoad_s);
		createTypeMetatable(l,constructor, typeof(BSFramework.AssetMgr));
	}
}
