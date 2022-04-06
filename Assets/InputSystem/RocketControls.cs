//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputSystem/RocketControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @RocketControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RocketControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RocketControls"",
    ""maps"": [
        {
            ""name"": ""RocketMovement"",
            ""id"": ""628626dd-d45f-4486-a9ef-5a995628aba3"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""323189f7-2acf-4ac4-a9bf-c9cf879d96fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""70262b1f-bfd5-433c-adde-4a3e3afe19bd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Debug_NextLevel"",
                    ""type"": ""Button"",
                    ""id"": ""897799de-4c02-4101-9720-f8df4c11cdcf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Debug_CollisionDisabled"",
                    ""type"": ""Button"",
                    ""id"": ""b28f4e45-1c06-4e45-bd23-a8027a6b65a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cde4136-5f34-4ce0-9b97-42d7affc07fb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c5911c9-ea22-4fa4-bed5-482abdfba2d8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""721b9fd3-d24c-4d18-9712-ee3085ba54e2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ecdc41ef-b01e-47ce-85bd-b94a0c635f2b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5169c5da-ed30-4603-9008-3054cf27d9b1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4443d0a6-af29-47d6-8d2d-5860f31dc43e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2af4d1e2-bcc3-46db-bdde-012864dc69f4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_NextLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd1eed73-80bd-4637-b1b5-73b172d7e124"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_NextLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19ff88a2-919f-46b0-9711-620b0911e11a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_CollisionDisabled"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afa104f3-dd72-4778-bb79-5d59a2908e5b"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_CollisionDisabled"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RocketMovement
        m_RocketMovement = asset.FindActionMap("RocketMovement", throwIfNotFound: true);
        m_RocketMovement_Thrust = m_RocketMovement.FindAction("Thrust", throwIfNotFound: true);
        m_RocketMovement_Pitch = m_RocketMovement.FindAction("Pitch", throwIfNotFound: true);
        m_RocketMovement_Debug_NextLevel = m_RocketMovement.FindAction("Debug_NextLevel", throwIfNotFound: true);
        m_RocketMovement_Debug_CollisionDisabled = m_RocketMovement.FindAction("Debug_CollisionDisabled", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RocketMovement
    private readonly InputActionMap m_RocketMovement;
    private IRocketMovementActions m_RocketMovementActionsCallbackInterface;
    private readonly InputAction m_RocketMovement_Thrust;
    private readonly InputAction m_RocketMovement_Pitch;
    private readonly InputAction m_RocketMovement_Debug_NextLevel;
    private readonly InputAction m_RocketMovement_Debug_CollisionDisabled;
    public struct RocketMovementActions
    {
        private @RocketControls m_Wrapper;
        public RocketMovementActions(@RocketControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_RocketMovement_Thrust;
        public InputAction @Pitch => m_Wrapper.m_RocketMovement_Pitch;
        public InputAction @Debug_NextLevel => m_Wrapper.m_RocketMovement_Debug_NextLevel;
        public InputAction @Debug_CollisionDisabled => m_Wrapper.m_RocketMovement_Debug_CollisionDisabled;
        public InputActionMap Get() { return m_Wrapper.m_RocketMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketMovementActions set) { return set.Get(); }
        public void SetCallbacks(IRocketMovementActions instance)
        {
            if (m_Wrapper.m_RocketMovementActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnThrust;
                @Pitch.started -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnPitch;
                @Debug_NextLevel.started -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_NextLevel;
                @Debug_NextLevel.performed -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_NextLevel;
                @Debug_NextLevel.canceled -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_NextLevel;
                @Debug_CollisionDisabled.started -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_CollisionDisabled;
                @Debug_CollisionDisabled.performed -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_CollisionDisabled;
                @Debug_CollisionDisabled.canceled -= m_Wrapper.m_RocketMovementActionsCallbackInterface.OnDebug_CollisionDisabled;
            }
            m_Wrapper.m_RocketMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Debug_NextLevel.started += instance.OnDebug_NextLevel;
                @Debug_NextLevel.performed += instance.OnDebug_NextLevel;
                @Debug_NextLevel.canceled += instance.OnDebug_NextLevel;
                @Debug_CollisionDisabled.started += instance.OnDebug_CollisionDisabled;
                @Debug_CollisionDisabled.performed += instance.OnDebug_CollisionDisabled;
                @Debug_CollisionDisabled.canceled += instance.OnDebug_CollisionDisabled;
            }
        }
    }
    public RocketMovementActions @RocketMovement => new RocketMovementActions(this);
    public interface IRocketMovementActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnDebug_NextLevel(InputAction.CallbackContext context);
        void OnDebug_CollisionDisabled(InputAction.CallbackContext context);
    }
}
