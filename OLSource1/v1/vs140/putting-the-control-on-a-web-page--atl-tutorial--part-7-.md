---
title: "Putting the Control on a Web Page (ATL Tutorial, Part 7)"
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
ms.assetid: 50dc4c95-c95b-4006-b88a-9826f7bdb222
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Putting the Control on a Web Page (ATL Tutorial, Part 7)
Your control is now finished. To see your control work in a real-world situation, put it on a Web page. An HTML file that contains the control was created when you defined your control. Open the PolyCtl.htm file from **Solution Explorer**, and you can see your control on a Web page.  
  
 In this step, you will script the Web page to respond to events. You will also modify the control to let Internet Explorer know that the control is safe for scripting.  
  
## Scripting the Web Page  
 The control does not do anything yet, so change the Web page to respond to the events that you send.  
  
#### To script the Web page  
  
1.  Open PolyCtl.htm and select HTML view. Add the following lines to the HTML code. They should be added after <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> but before <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Save the HTM file.  
  
 You have added some VBScript code that gets the Sides property from the control and increases the number of sides by one if you click inside the control. If you click outside the control, you reduce the number of sides by one.  
  
## Indicating that the Control Is Safe for Scripting  
 You can view the Web page with the control in Internet Explorer or, more conveniently, use the Web browser view built into Visual C++. To see your control in the Web browser view, right-click PolyCtl.htm, and click **View in Browser**.  
  
 Based on your current Internet Explorer security settings, you may receive a Security Alert dialog box stating that the control may not be safe to script and could potentially do damage. For example, if you had a control that displayed a file but also had a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method that deleted a file, it would be safe if you just viewed it on a page. It would be not safe to script, however, because someone could call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
> [!IMPORTANT]
>  For this tutorial, you can change your security settings in Internet Explorer to run ActiveX controls that are not marked as safe. In Control Panel, click **Internet Properties** and click **Security** to change the appropriate settings. When you have completed the tutorial, change your security settings back to their original state.  
  
 You can programmatically alert Internet Explorer that it does not need to display the Security Alert dialog box for this particular control. You can do this with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface, and ATL supplies an implementation of this interface in the class [IObjectSafetyImpl](../vs140/iobjectsafetyimpl-class.md). To add the interface to your control, add <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to your list of inherited classes and add an entry for it in your COM map.  
  
#### To add IObjectSafetyImpl to the control  
  
1.  Add the following line to the end of the list of inherited classes in PolyCtl.h and add a comma to the previous line:  
  
     [!code[NVC_ATL_Windowing#62](../vs140/codesnippet/CPP/putting-the-control-on-a-web-page--atl-tutorial--part-7-_1.h)]  
  
2.  Add the following line to the COM map in PolyCtl.h:  
  
     [!code[NVC_ATL_Windowing#63](../vs140/codesnippet/CPP/putting-the-control-on-a-web-page--atl-tutorial--part-7-_2.h)]  
  
## Building and Testing the Control  
 Build the control. Once the build has finished, open PolyCtl.htm in browser view again. This time, the Web page should be displayed directly without the Safety Alert dialog box. Click inside the polygon; the number of sides increases by one. Click outside the polygon to reduce the number of sides. If you try to reduce the number of sides below three, you will see the error message that you set.  
  
 [Back to Step 6](../vs140/adding-a-property-page--atl-tutorial--part-6-.md)  
  
## Next Steps  
 This concludes the ATL tutorial. For links to more information about ATL, see the [ATL start page](../vs140/active-template-library--atl--concepts.md).  
  
## See Also  
 [Tutorial](../vs140/active-template-library--atl--tutorial.md)