---
title: "How to: Filter Data in a LightSwitch Application by Using Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8a81c2b8-b8d4-4869-8629-edb5f82a257b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Filter Data in a LightSwitch Application by Using Code
By using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> query method, you can display a subset of records for each user based on permissions. For example, you might want to allow each employee to display only their salary information.  
  
### To apply a filter  
  
1.  In **Solution Explorer**, open the shortcut menu for the entity or table to which you want to apply a filter, and then choose **Open**.  
  
     The entity or table opens in the **Data Designer**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  On the command bar in the **Data Designer**, in the **Write Code** list, choose *EntitySet***_Filter**.  
  
3.  In the **Code Editor**, add code to the method.  
  
     The following code example filters the Employees entity so that the current user can display only the records that contain their Employee Name:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [How to: Handle Data Events](../vs140/how-to--handle-data-events.md)   
 [Working with Data-Related Objects in Code](../vs140/working-with-data-related-objects-in-code.md)