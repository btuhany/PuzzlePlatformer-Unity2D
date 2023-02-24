using Animations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



//Delete public
public class Health : MonoBehaviour
{
    [SerializeField] int _maxHealth;
    [SerializeField] bool _IsCooldownAfterHit;
    [SerializeField] float _cooldownTimeAfterHit;
    bool _isInvulnerable;
    public int _currentHealth;
    public bool IsDead => _currentHealth <= 0;
    public event System.Action OnDead;      //////////////////////////////////////
    CharacterAnimation _anim;

    private void Awake()
    {
        _anim = GetComponent<CharacterAnimation>();
        _currentHealth = _maxHealth;
    }
    private void OnEnable()
    {
        OnDead += HandleOnDead;
    }

    private void HandleOnDead()
    {
        _currentHealth = _maxHealth;
        _anim.AppearAnim(0.4f);
    }

    public void TakeHit(Damage damage)
    {
        if (_isInvulnerable) 
        { 
            return; 
        }
        
        _currentHealth -= damage.HitDamage;
        StartCoroutine(HitCooldown());
        if (IsDead)
            OnDead?.Invoke();
    }
    IEnumerator HitCooldown()
    {
        _isInvulnerable= true;
        _anim.TakeHitAnim(true);
        yield return new WaitForSeconds(_cooldownTimeAfterHit);
        _isInvulnerable = false;
        _anim.TakeHitAnim(false);

    }
    


}
