using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPExit : Identity
    {
        public GameObject YouWin;
        // กำหนดชื่อไอเท็มและจำนวนที่ต้องการใช้ในการเปิดทางออก

        public override bool Hit()
        {
            // ตรวจสอบว่าผู้เล่นมีไอเท็มที่ต้องการหรือไม่

            var keyAmout = mapGenerator.player.inventory.GetItemCount("key");
            if (keyAmout >= 2)
            {
                YouWin.SetActive(true);
                Debug.Log("You win");
            }
           
            return true;
          
        }
    }
}