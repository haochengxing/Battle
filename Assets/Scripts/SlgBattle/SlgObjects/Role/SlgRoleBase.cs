using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlgRoleBase:SlgObject
{
    SlgRoleViewBase view;
    Vector3 position;
    Vector3 eulerAngles;
    public int gId;
    public int logicX;
    public int logicZ;
    public virtual void Init()
    {
        
    }

    public virtual void Update(float deltaTime)
    {

    }

    public virtual void Release()
    {

    }
    public virtual void SetView(SlgRoleViewBase view)
    {
        this.view = view;
    }
    public Vector3 GetPosition()
    {
        return position;
    }
    public void SetPosition(Vector3 position)
    {
        this.position.Set(position.x, position.y, position.z);
        if (view!=null)
        {
            view.UpdatePosition();
        }
    }
    public Vector3 GetEulerAngles()
    {
        return eulerAngles;
    }
    public void SetEulerAngles(Vector3 eulerAngles)
    {
        this.eulerAngles.Set(eulerAngles.x, eulerAngles.y, eulerAngles.z);
        if (view != null)
        {
            view.UpdateRotation();
        }
    }
    public void SetLogicPosition(int x,int z)
    {
        logicX = x;
        logicZ = z;
    }
    public void SetRotationY(float y)
    {
        eulerAngles.y = y;
        if (view != null)
        {
            view.UpdateRotation();
        }
    }
    public virtual void DoAction(string animationName)
    {
        if (view != null)
        {
            view.DoAction(animationName);
        }
    }
    public virtual void StartAtk()
    {

    }
}
