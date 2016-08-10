local LuaLog, tablePrint_ptk = setLuaLog(1, "SceneManager")

local className = "SceneManager"
local GameSceneManager = Declare(className, Class(className))

SceneManager.instance = nil

function SceneManager:ctor()

end

function SceneManager:dtor()

end

function SceneManager.GetInstance()
    if SceneManager.instance == nil then
        SceneManager.instance = SceneManager.new()
    end
    return SceneManager.instance
end

function SceneManager:LoadSceneAsync(sceneName, OnAssetLoaded, OnProgress)
    local sceneAsset = BSFramework.AssetMgr.LoadScene(sceneName)
    sceneAsset.OnAssetLoaded = OnAssetLoaded
    sceneAsset.OnProgress = OnProgress
    sceneAsset:Load()
    return sceneAsset
end