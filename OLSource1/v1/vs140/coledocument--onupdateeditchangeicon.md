---
title: "COleDocument::OnUpdateEditChangeIcon"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDocument.OnUpdateEditChangeIcon"
  - "COleDocument::OnUpdateEditChangeIcon"
  - "OnUpdateEditChangeIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateEditChangeIcon method"
  - "COleDocument class, message handlers"
ms.assetid: a35da84d-afca-4d08-b69f-50a061a68393
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnUpdateEditChangeIcon
Called by the framework to update the Change Icon command on the Edit menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that represents the menu that generated the update command. The update handler calls the **Enable** member function of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure through <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to update the user interface.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> updates the command's user interface depending on whether or not a valid icon exists in the document. Override this function to change the behavior.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnEditChangeIcon](../vs140/coledocument--oneditchangeicon.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)