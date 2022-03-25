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
                    ""id"": ""721b9fd3-d24c-4d18-9712-ee3085ba54e2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
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
    public struct RocketMovementActions
    {
        private @RocketControls m_Wrapper;
        public RocketMovementActions(@RocketControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_RocketMovement_Thrust;
        public InputAction @Pitch => m_Wrapper.m_RocketMovement_Pitch;
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
            }
        }
    }
    public RocketMovementActions @RocketMovement => new RocketMovementActions(this);
    public interface IRocketMovementActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
    }
}
