using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEditor;


public class options : MonoBehaviour
{
     Button menu_1, menu_2, menu_3, menu_4;
     Button[] bttns = new Button[3];
     StyleColor[] colors = new StyleColor[3];
     GameObject[] sub_menus = new GameObject[3]; // allocate 3 sub_menus

          GameObject go;
          
     bool status;
     int count;
     bool ctrl;

    // Start is called before the first frame update
    void Start()
    {
        UIDocument uid = gameObject.GetComponent<UIDocument>();
        var root = uid.rootVisualElement;

        menu_1 = root.Q<Button>("menu_1");
        menu_2 = root.Q<Button>("menu_2");
        menu_3 = root.Q<Button>("menu_3");
        menu_4 = root.Q<Button>("menu_4");
     
        bttns[0] = root.Q<Button>("menu_1");
         bttns[1] = root.Q<Button>("menu_2");
          bttns[2] = root.Q<Button>("menu_3");
           
         sub_menus[0] = GameObject.Find("sub_menu_1");
          sub_menus[1] = GameObject.Find("sub_menu_2");
            sub_menus[2] = GameObject.Find("sub_menu_3"); 
            
     
          
      bttns[0].clicked += () => switch_option(bttns[0]);
       bttns[1].clicked += () => switch_option(bttns[1]);
        bttns[2].clicked += () => switch_option(bttns[2]);


        menu_4.clicked += () => SceneManager.LoadScene(1);
        
        status = false;
        count = 0;
        ctrl = true;
        
    }
         
     // Update is called once per frame
    void Update()
    {
    
                  count += 1;
           if (count > 1  && ctrl) {
           
           for (int i = 0; i < bttns.Length; i++) colors[i] = bttns[i].resolvedStyle.backgroundColor; 
          
                                   }
           
               if (count > 1) ctrl = false;                 
          
                  
     } // end of Update()        
         
  void switch_option(Button bttn) {  

float delay = 0f;

for (int i = 0; i < bttns.Length; i++) {

if (bttns[i] != bttn) {bttns[i].style.backgroundColor = colors[i];

  // INSERT HERE YOUR LEANTWEEN FUNCTION HO HIDE SUB-MENU.USE set.Delay(0) and setEase()
 LeanTween.moveY(sub_menus[i].GetComponent<RectTransform>(), -5000, 1.5f);

} else {

bttns[i].style.backgroundColor = new StyleColor(new Color(1f,1f,1f,0.5f));

if (status) delay = 1; // DONT FORGET TO SET DELAY-TIME

    // INSERT HERE YOUR LEANTWEEN FUNCTION TO SHOW THE SUB-MENU USE set.Delay(DELAY_TIME) AND setEase()
    LeanTween.moveY(sub_menus[i].GetComponent<RectTransform>(), -205, 1.5f);
    status = true;

         }                                                                

                                       }          
                   
                               }

}       
       
 
    
    


        
           

        
           
         
            
          
                   
        
 
  
    
    




