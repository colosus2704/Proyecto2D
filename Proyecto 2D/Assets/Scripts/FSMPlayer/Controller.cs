using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public class Controller : MonoBehaviour
    {
        public State currentState; // apuntador al estado actual
        public State remainState;  // el estado en el que te quedas si no pasas a la siguiente

        private HealthSystem _healthSystem;
        internal int GetCurrentHealth()
        {
            return _healthSystem.GetHealth();
        }

        public void SetAnimation(string animation, bool value)
        {
            _animatorController.SetBool(animation, value);
        }

        public bool ActiveAI { get; set; }

        public void Start()
        {
            ActiveAI = true; // Para activar la IA
        }

        private Animator _animatorController;
        //private HealthSystem _healtSystem;

        private void Awake()
        {
            _animatorController = GetComponent<Animator>();
            _healthSystem = GetComponent<HealthSystem>();
        }

        public void Update() // Se ejecutan las acciones del estado actual.
        {
            if (!ActiveAI)                   // El par�metro permite que los 
                return;                      // estados tengan una referencia al
            currentState.UpdateState(this);  // controlador, para poder llamar a
                                             // sus m�todos
        }

        public void Transition(State nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
            }
        }
    }
}