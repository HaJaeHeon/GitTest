using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField] private PlayerSkill_Aura aura;
    [SerializeField] private PlayerSkill_FireBlast fireBlast;
    [SerializeField] private PlayerSkill_MagicMissle magicMissle;
    [SerializeField] private PlayerSkill_Saw saw;
    [SerializeField] private PlayerSkill_SpikeBall spikeBall;

    private void Awake()
    {
        aura = GetComponent<PlayerSkill_Aura>();
        fireBlast = GetComponent<PlayerSkill_FireBlast>();
        magicMissle = GetComponent<PlayerSkill_MagicMissle>();
        saw = GetComponent<PlayerSkill_Saw>();
        spikeBall = GetComponent<PlayerSkill_SpikeBall>();
    }

    private void Update()
    {
        CastingAura();
        CastingFireBlast();
        CastingMagicMissile();
        CastingSaw();
        CastingSpikeBall();
    }

    private void CastingAura()
    {
        aura.CastSkill(gameObject);
    }
    private void CastingFireBlast()
    {
        fireBlast.CastSkill(gameObject);
    }
    private void CastingMagicMissile()
    {
        magicMissle.CastSkill(gameObject);
    }
    private void CastingSaw()
    {
        saw.CastSkill(gameObject);
    }
    private void CastingSpikeBall()
    {
        spikeBall.CastSkill(gameObject);
    }
}
