using AdventureSouls;
using UnityEngine;

public class WeaponSlot : SoulsWeaponSlot
{
    [Tooltip("will be used to copy the skinning bones to the armor renderer, usually the main character mesh")]
    public SkinnedMeshRenderer Template;

    protected override void equip(SoulsWeaponItem item)
    {
        base.equip(item);

        var skinnedMeshRenderer = Weapon.GetComponent<SkinnedMeshRenderer>();

        if (skinnedMeshRenderer)
        {
            skinnedMeshRenderer.rootBone = Template.rootBone;
            skinnedMeshRenderer.bones = Template.bones;
        }
    }
}
