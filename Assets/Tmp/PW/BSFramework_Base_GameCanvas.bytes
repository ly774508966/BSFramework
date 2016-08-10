local LuaLog, tablePrint_ptk = setLuaLog(1, "GameCanvas")
local className = "GameCanvas"
local GameCanvas = Declare(className, Class(className))

GameCanvas.instance = nil

function GameCanvas:ctor()
    -- LuaLog("GameCanvas:ctor=====================")
    self:CreateCanvas(Vector2(1024, 768))
    -- self.canvasObj = nil
    -- self.canvas = nil
    -- self.canvasScaler = nil
    -- self.graphicRaycaster = nil
    -- self.eventSystemObj = nil
    -- self.eventSystem = nil
end

function GameCanvas:dtor()
    -- LuaLog("GameCanvas:dtor=====================")
end

function GameCanvas.GetInstance( ... )
    if GameCanvas.instance == nil then
        GameCanvas.instance = GameCanvas.new()
    end
    return GameCanvas.instance
end

function GameCanvas:CreateUICamera()
    local gameObj = GameObject("UICamera")
    local camera = gameObj:AddComponent(Camera)
    local camera = gameObj:GetComponent("Camera")
    -- local flare = gameObj:GetComponent("FlareLayer")
    -- gameObj.Destroy(flare)
    -- local gui = gameObj:GetComponent("GUILayer")
    -- LuaLog(gui)
    -- gameObj.Destroy(gui)
    -- local audio = gameObj:GetComponent("AudioListener")
    -- gameObj.Destroy(audio)
    camera.clearFlags = CameraClearFlags.Depth
    camera.cullingMask = 32 -- 1<<5
    camera.orthographic = true
    GameObject.DontDestroyOnLoad(camera)
    return camera
end

function GameCanvas:CreateCanvas(designVector2)
    self.canvasObj = GameObject("UICanvas")
    self.canvasObj.layer = 5
    self.canvas = self.canvasObj:AddComponent(Canvas)
    self.canvasScaler = self.canvasObj:AddComponent(CanvasScaler)
    self.graphicRaycaster = self.canvasObj:AddComponent(GraphicRaycaster)

   -- self.canvas.renderMode = RenderMode.ScreenSpaceOverlay
    self.canvas.renderMode = RenderMode.ScreenSpaceCamera
    self.canvas.worldCamera = self:CreateUICamera()
    self.canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize
    self.canvasScaler.matchWidthOrHeight = 0
    self.canvasScaler.referenceResolution = designVector2

    GameObject.DontDestroyOnLoad(self.canvasObj)

    self.eventSystemObj = GameObject("EventSystem")
    self.eventSystemObj:AddComponent(EventSystem)
    self.eventSystemObj:AddComponent(StandaloneInputModule)

    GameObject.DontDestroyOnLoad(self.eventSystemObj)

    self.canvasObj.transform.localScale = Vector3.one
    -- LuaLog("EventSystemEventSystemEventSystem")
    -- self.eventSystemObj:AddComponent(TouchInputModule)
end

function GameCanvas:SetReferenceResolution(designVector2)
    self.canvasScaler.referenceResolution = designVector2
end