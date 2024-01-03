using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public abstract class SlgRoleViewBase
{
    GameObject viewObject;
    SlgRoleBase roleInfo;
    Animator animator;
    public virtual void Init(SlgRoleBase roleInfo)
    {
        this.roleInfo = roleInfo;
        LoadModel();
    }

    public virtual void Update(float deltaTime)
    {

    }

    public virtual void Release()
    {

    }
    public virtual void LoadModel()
    {
        GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/UnityChan/Prefabs/unitychan.prefab");
        viewObject = GameObject.Instantiate(go);
        animator = viewObject.GetComponent<Animator>();
        UpdatePosition();
        UpdateRotation();
    }
    public virtual void UpdatePosition()
    {
        if (viewObject==null || roleInfo==null)
        {
            return;
        }
        viewObject.transform.position = roleInfo.GetPosition();
    }
    public virtual void UpdateRotation()
    {
        if (viewObject == null || roleInfo == null)
        {
            return;
        }
        viewObject.transform.eulerAngles = roleInfo.GetEulerAngles();
    }
    public virtual void DoAction(string animationName)
    {
        animator.Play(animationName);
    }
}
