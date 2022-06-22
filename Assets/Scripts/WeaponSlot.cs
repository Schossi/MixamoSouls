using AdventureSouls;
using UnityEngine;

public class WeaponSlot : SoulsWeaponSlot
{
    [Tooltip("will be used to copy the skinning bones to the armor renderer, usually the main character mesh")]
    public SkinnedMeshRenderer Renderer;

    protected override void equip(SoulsWeaponItem item)
    {
        base.equip(item);

        var meshFilter = Weapon.GetComponent<MeshFilter>();
        var meshRenderer = Weapon.GetComponent<MeshRenderer>();//old souls items have their own renderer

        if (meshFilter && !meshRenderer)
            Renderer.sharedMesh = meshFilter.mesh;
        else
            Renderer.sharedMesh = null;
    }
}
