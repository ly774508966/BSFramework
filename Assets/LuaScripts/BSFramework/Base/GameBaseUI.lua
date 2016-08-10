require "BSFramework.Base.GameCanvas"

local LuaLog, tablePrint_ptk = setLuaLog(1, "GameBaseUI")
local className = "GameBaseUI"
local GameBaseUI = Declare(className, Class(className))

function GameBaseUI:ctor()
    -- LuaLog("GameBaseUI:ctor=====================")
    self.GameCanvas = GameCanvas.GetInstance()
end

function GameBaseUI:dtor()
    LuaLog("GameBaseUI:dtor")
end

function GameBaseUI:RestRectTransform(obj)
    obj.transform.anchorMin = Vector2.zero
    obj.transform.anchorMax = Vector2.one
    obj.transform.sizeDelta = Vector2.zero
    obj.transform.anchoredPosition = Vector2.zero
    obj.transform.anchoredPosition3D = Vector3.zero
    obj.transform.localScale = Vector3.one
end

function GameBaseUI:SetPosition(obj, pos)
    -- LuaLog("=====================")
    obj.transform.anchoredPosition = pos
end

function GameBaseUI:AddChildWithCanvas(obj)
    obj.transform:SetParent(self.GameCanvas.canvasObj.transform, false)
    self:RestRectTransform(obj)
end

function GameBaseUI:AddChildWithObject(srcObj, destObj)
    srcObj.transform:SetParent(destObj.transform, false)
    self:RestRectTransform(srcObj)
end

function GameBaseUI:AddChildWithTransform(src, dest)
    src:SetParent(dest, false)
    self:RestRectTransform(src.gameObject)
end

function GameBaseUI:AddCanvasWithInstantiate(obj)
    local uiObject = GameObject.Instantiate(obj)
    self:AddChildWithCanvas(uiObject)
    self:RestRectTransform(uiObject)
    return uiObject
end

function GameBaseUI:AddChildWithInstantiate(srcObj, destObj)
    local uiObject = GameObject.Instantiate(srcObj)
    self:AddChildWithObject(uiObject, destObj)
    return uiObject
end

function GameBaseUI:RemoveGameObject(itemObj, flag)
    local flag = flag or false
    if flag == false then
        GameObject.Destroy(itemObj)
    else
        GameObject.DestroyImmediate(itemObj)
    end
end

function GameBaseUI:AssetLoad(assetName, OnAssetLoaded, OnProgress)
    local asset = BSFramework.AssetMgr.Load(assetName)
    asset.OnAssetLoaded = OnAssetLoaded
    asset.OnProgress = OnProgress
    asset:Load()
    return asset
end

function GameBaseUI:AssetLoadWithCanvasInstantiate(assetName, OnInstantiateComplete)
    local function OnAssetLoaded(obj, asset)
        OnInstantiateComplete(self:AddCanvasWithInstantiate(obj))
        asset:UnLoad()
    end
    self:AssetLoad(assetName, OnAssetLoaded)
end

function GameBaseUI:AssetLoadWithChildInstantiate(assetName, destObj, OnInstantiateComplete)
    local function OnAssetLoaded(obj, asset)
        OnInstantiateComplete(self:AddChildWithInstantiate(obj, destObj))
        asset:UnLoad()
    end
    self:AssetLoad(assetName, OnAssetLoaded)
end

function GameBaseUI:GetUIControl(args1, args2, args3)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, args3)
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, args3)
    end
end

function GameBaseUI:GetTextControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Text")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Text")
    end
end

function GameBaseUI:GetButtonControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Button")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Button")
    end
end

function GameBaseUI:GetImageControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Image")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Image")
    end
end

function GameBaseUI:GetSliderControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Slider")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Slider")
    end
end

function GameBaseUI:GetToggleControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Toggle")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Toggle")
    end
end

function GameBaseUI:GetRawImageControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.RawImage")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.RawImage")
    end
end

function GameBaseUI:GetScrollbarControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Scrollbar")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Scrollbar")
    end
end

function GameBaseUI:GetInputFieldControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.InputField")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.InputField")
    end
end

function GameBaseUI:GetScrollRectControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.ScrollRect")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.ScrollRect")
    end
end

function GameBaseUI:GetDropdownControl(args1, args2)
    if args2 ~= nil then
        return BSFramework.Tools.LuaHelper.FindChildIsComponent(args1, args2, "UnityEngine.UI.Dropdown")
    else
        return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.UI.Dropdown")
    end
end

function GameBaseUI:GetSpriteRenderer(args1)
    return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.SpriteRenderer")
end

function GameBaseUI:GetSpriteRendererWithSprite(args1)
    return BSFramework.Tools.LuaHelper.GetComponent(args1, "UnityEngine.SpriteRenderer").sprite
end

function GameBaseUI:AssetLoadWithSprite(assetName, OnSpriteComplete)
    local function OnAssetLoaded(obj, asset)
        OnSpriteComplete(self:GetSpriteRendererWithSprite(obj))
        asset:UnLoad()
    end
    self:AssetLoad(assetName, OnAssetLoaded)
end

function GameBaseUI:OnClick(control, callfun)
    control.onClick:AddListener(callfun)
end

function GameBaseUI:OnValueChanged(control, callfun)
    control.onValueChanged:AddListener(callfun)
end

function GameBaseUI:OnEndEdit(control, callfun)
    control.onEndEdit:AddListener(callfun)
end