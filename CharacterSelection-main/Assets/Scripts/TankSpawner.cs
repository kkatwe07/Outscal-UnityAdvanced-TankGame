using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotateSpeed;
    public TankView tankView;
       
    void Start()
    {
        CreateTank(); 
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(movementSpeed, rotateSpeed);
        TankController tankController = new TankController(tankModel, tankView);
    }
   
}