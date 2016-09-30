---
title: "Adding a Property to the Control (ATL Tutorial, Part 3)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
ms.assetid: f775fe34-103b-4f07-9999-400e987ee030
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding a Property to the Control (ATL Tutorial, Part 3)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is the interface that contains the control's custom methods and properties, and you will add a property to it.  
  
### To add a property using the Add Property Wizard  
  
1.  In Class View, expand the Polygon branch.  
  
2.  Right-click IPolyCtl.  
  
3.  On the shortcut menu, click **Add**, and then click **Add Property**.  
  
     The Add Property Wizard will appear.  
  
4.  In the drop-down list of property types, select <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
5.  Type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as the **Property name.**  
  
6.  Click **Finish** to finish adding the property.  
  
 When you add the property to the interface, MIDL (the program that compiles .idl files) defines a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method for retrieving its value and a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method for setting a new value. The methods are named by prepending <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the property name.  
  
 The Add Property Wizard adds the necessary lines to the .idl file. It also adds the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function prototypes to the class definition in PolyCtl.h and adds an empty implementation to PolyCtl.cpp. You can check this by opening PolyCtl.cpp and looking for the functions <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Although you now have skeleton functions to set and retrieve the property, it needs a place to be stored. You will create a variable to store the property and update the functions accordingly.  
  
#### To create a variable to store the property, and update the put and get methods  
  
1.  From Solution Explorer, open PolyCtl.h and add the following line after the definition of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
     [!code[NVC_ATL_Windowing#44](../vs140/codesnippet/CPP/adding-a-property-to-the-control--atl-tutorial--part-3-_1.h)]  
  
2.  Set the default value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Make the default shape a triangle by adding a line to the constructor in PolyCtl.h:  
  
     [!code[NVC_ATL_Windowing#45](../vs140/codesnippet/CPP/adding-a-property-to-the-control--atl-tutorial--part-3-_2.h)]  
  
3.  Implement the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> methods. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function declarations have been added to PolyCtl.h. Replace the code in PolyCtl.cpp for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> with the following code:  
  
     [!code[NVC_ATL_Windowing#46](../vs140/codesnippet/CPP/adding-a-property-to-the-control--atl-tutorial--part-3-_3.cpp)]  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method returns the current value of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> property through the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pointer. In the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method, the code ensures the user is setting the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> property to an acceptable value. The minimum must be 2, and because an array of points will be used for each side, 100 is a reasonable limit for a maximum value.  
  
 You now have a property called <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. In the next step, you will change the drawing code to use it.  
  
 [Back to Step 2](../vs140/adding-a-control--atl-tutorial--part-2-.md) &#124; [On to Step 4](../vs140/changing-the-drawing-code--atl-tutorial--part-4-.md)  
  
## See Also  
 [Tutorial](../vs140/active-template-library--atl--tutorial.md)