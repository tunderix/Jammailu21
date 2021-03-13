// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerData/MyControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""83b63543-46cc-452e-ab7c-1429b6ac41ff"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8a995ac-cdcc-454a-a3a2-7139e217efc4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""6fbb16b3-de98-4e83-94bd-70d79d2236ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""943ff661-6b69-483e-89ef-18ee8999cf78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Aim Mode"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0b5b70cb-d77c-4ecc-9569-f1401d8cf840"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""42254098-f0fe-40cc-8459-4c6f830c89a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1a33ee67-9cac-47bb-8e6f-53f0f308475a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ff6e0c7c-3f95-4a1f-b909-733b1d9361a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll/Dash"",
                    ""type"": ""Button"",
                    ""id"": ""ccf54da7-de33-4e72-9108-b8dce30680e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""a423e20c-0d75-4abd-bfc2-5c6b24778811"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83ed7872-1271-40b5-a8b1-8cfa44b9a383"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b3f4540-35f3-41ed-972f-1aed80c04c0a"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""817480be-5a4c-4ed7-a90e-6fc4f0a7047a"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63dcb947-1130-4fa2-bb6d-880e6169ca8f"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Aim Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9876360e-60dd-42ba-8ace-bde482469519"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efad1ea4-f570-4fba-b6a9-bfa36e8b9fa7"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c74028df-a64a-4e0c-a014-b156ba3d90fb"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""872073f8-158f-41a5-b66b-12496aaa3579"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Roll/Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""413c4678-c0a2-4762-9d0c-233b97f1b3b2"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Aim Mode"",
            ""id"": ""881cb56a-2a42-42e9-8b15-452043f65c86"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""d538de7f-c05a-4298-b52a-cc08fd527f09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Draw Bow"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b0ca069e-c210-4df5-9f61-a7eed80d0ecb"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4e6d9753-0e04-4887-aa95-1b56083814fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a45757d-0aac-436b-bfd1-70443638f6cd"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce658cde-56af-4b7d-884e-0dda409ca39e"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Draw Bow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d0a5be4b-db9a-4c27-9f2b-21dc38978ca2"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cd085a96-964b-4965-84b8-3b2cacc5ef6c"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""948d4e07-c03c-4310-b025-5e5dde2b30bd"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""26f248b3-9342-4c16-9d4c-92935a86f4a0"",
                    ""path"": ""<DualShockGamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8b5677b1-c1b8-4a81-bdc1-f854a6d2d838"",
                    ""path"": ""<DualShockGamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad2"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad2"",
            ""bindingGroup"": ""Gamepad2"",
            ""devices"": []
        },
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Move = m_Land.FindAction("Move", throwIfNotFound: true);
        m_Land_Fire = m_Land.FindAction("Fire", throwIfNotFound: true);
        m_Land_Sprint = m_Land.FindAction("Sprint", throwIfNotFound: true);
        m_Land_AimMode = m_Land.FindAction("Aim Mode", throwIfNotFound: true);
        m_Land_Use = m_Land.FindAction("Use", throwIfNotFound: true);
        m_Land_Attack = m_Land.FindAction("Attack", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_RollDash = m_Land.FindAction("Roll/Dash", throwIfNotFound: true);
        m_Land_Reload = m_Land.FindAction("Reload", throwIfNotFound: true);
        // Aim Mode
        m_AimMode = asset.FindActionMap("Aim Mode", throwIfNotFound: true);
        m_AimMode_Fire = m_AimMode.FindAction("Fire", throwIfNotFound: true);
        m_AimMode_DrawBow = m_AimMode.FindAction("Draw Bow", throwIfNotFound: true);
        m_AimMode_Aim = m_AimMode.FindAction("Aim", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Move;
    private readonly InputAction m_Land_Fire;
    private readonly InputAction m_Land_Sprint;
    private readonly InputAction m_Land_AimMode;
    private readonly InputAction m_Land_Use;
    private readonly InputAction m_Land_Attack;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_RollDash;
    private readonly InputAction m_Land_Reload;
    public struct LandActions
    {
        private @MyControls m_Wrapper;
        public LandActions(@MyControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Land_Move;
        public InputAction @Fire => m_Wrapper.m_Land_Fire;
        public InputAction @Sprint => m_Wrapper.m_Land_Sprint;
        public InputAction @AimMode => m_Wrapper.m_Land_AimMode;
        public InputAction @Use => m_Wrapper.m_Land_Use;
        public InputAction @Attack => m_Wrapper.m_Land_Attack;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @RollDash => m_Wrapper.m_Land_RollDash;
        public InputAction @Reload => m_Wrapper.m_Land_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Fire.started -= m_Wrapper.m_LandActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnFire;
                @Sprint.started -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @AimMode.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAimMode;
                @AimMode.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAimMode;
                @AimMode.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAimMode;
                @Use.started -= m_Wrapper.m_LandActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnUse;
                @Attack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @RollDash.started -= m_Wrapper.m_LandActionsCallbackInterface.OnRollDash;
                @RollDash.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnRollDash;
                @RollDash.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnRollDash;
                @Reload.started -= m_Wrapper.m_LandActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @AimMode.started += instance.OnAimMode;
                @AimMode.performed += instance.OnAimMode;
                @AimMode.canceled += instance.OnAimMode;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RollDash.started += instance.OnRollDash;
                @RollDash.performed += instance.OnRollDash;
                @RollDash.canceled += instance.OnRollDash;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // Aim Mode
    private readonly InputActionMap m_AimMode;
    private IAimModeActions m_AimModeActionsCallbackInterface;
    private readonly InputAction m_AimMode_Fire;
    private readonly InputAction m_AimMode_DrawBow;
    private readonly InputAction m_AimMode_Aim;
    public struct AimModeActions
    {
        private @MyControls m_Wrapper;
        public AimModeActions(@MyControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_AimMode_Fire;
        public InputAction @DrawBow => m_Wrapper.m_AimMode_DrawBow;
        public InputAction @Aim => m_Wrapper.m_AimMode_Aim;
        public InputActionMap Get() { return m_Wrapper.m_AimMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AimModeActions set) { return set.Get(); }
        public void SetCallbacks(IAimModeActions instance)
        {
            if (m_Wrapper.m_AimModeActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_AimModeActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_AimModeActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_AimModeActionsCallbackInterface.OnFire;
                @DrawBow.started -= m_Wrapper.m_AimModeActionsCallbackInterface.OnDrawBow;
                @DrawBow.performed -= m_Wrapper.m_AimModeActionsCallbackInterface.OnDrawBow;
                @DrawBow.canceled -= m_Wrapper.m_AimModeActionsCallbackInterface.OnDrawBow;
                @Aim.started -= m_Wrapper.m_AimModeActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_AimModeActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_AimModeActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_AimModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @DrawBow.started += instance.OnDrawBow;
                @DrawBow.performed += instance.OnDrawBow;
                @DrawBow.canceled += instance.OnDrawBow;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public AimModeActions @AimMode => new AimModeActions(this);
    private int m_Gamepad2SchemeIndex = -1;
    public InputControlScheme Gamepad2Scheme
    {
        get
        {
            if (m_Gamepad2SchemeIndex == -1) m_Gamepad2SchemeIndex = asset.FindControlSchemeIndex("Gamepad2");
            return asset.controlSchemes[m_Gamepad2SchemeIndex];
        }
    }
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface ILandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnAimMode(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRollDash(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IAimModeActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnDrawBow(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
