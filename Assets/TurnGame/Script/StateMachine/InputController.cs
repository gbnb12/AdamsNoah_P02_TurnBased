using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{
    public event Action PressedConfirm = delegate { };
    public event Action PressedCancel = delegate { };
<<<<<<< HEAD
    public event Action PressedAttack = delegate { };
    public event Action PressedDefend = delegate { };
    public event Action PressedLaser = delegate { };
    public event Action PressedHeal = delegate { };

=======
    public event Action PressedLeft = delegate { };
    public event Action PressedRight = delegate { };
    public event Action PressedAttack = delegate { };
    public event Action PressedDefend = delegate { };
    public event Action PressedMagic = delegate { };
    public event Action PressedHeal = delegate { };

    [SerializeField] Collider _playerPiece;
    [SerializeField] Collider _AIPiece;
>>>>>>> main

    private void Update()
    {
        DetectConfirm();
        DetectCancel();
<<<<<<< HEAD
        DetectAttack();
        DetectDefend();
        DetectLaser();
=======
        DetectLeft();
        DetectRight();
        DetectAttack();
        DetectDefend();
        DetectMagic();
>>>>>>> main
        DetectHeal();
    }

    private void DetectCancel()
    {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.C))
        {
            PressedCancel?.Invoke();
        }
    }

    private void DetectConfirm()
    {
        if (Input.GetKeyDown(KeyCode.Space))
=======
        if (Input.GetKeyDown(KeyCode.R))
>>>>>>> main
        {
            PressedConfirm?.Invoke();
        }
    }

    private void DetectAttack()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            PressedAttack?.Invoke();
            
        }
    }

    private void DetectDefend()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            PressedDefend?.Invoke();
        }
    }

    private void DetectLaser()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            PressedLaser?.Invoke();
            
        }
    }

<<<<<<< HEAD
=======
    private void DetectAttack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PressedAttack?.Invoke();
            IDamageable damage = _AIPiece.GetComponent<IDamageable>();
            if (damage != null)
                {
                    damage.TakeDamage(50); 
                }
        }
    }

    private void DetectDefend()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            PressedDefend?.Invoke();
        }
    }

    private void DetectMagic()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PressedMagic?.Invoke();
            IDamageable damage = _AIPiece.GetComponent<IDamageable>();
            if (damage != null)
            {
                damage.TakeDamage(100);
            }
        }
    }

>>>>>>> main
    private void DetectHeal()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            PressedHeal?.Invoke();
<<<<<<< HEAD
            
=======
            IDamageable recover = _AIPiece.GetComponent<IDamageable>();
            if (recover != null)
            {
                recover.Heal(20);
            }
>>>>>>> main
        }
    }
}


