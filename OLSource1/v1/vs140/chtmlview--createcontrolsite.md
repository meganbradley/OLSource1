---
title: "CHtmlView::CreateControlSite"
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
  - "CHtmlView::CreateControlSite"
  - "CreateControlSite"
  - "CHtmlView.CreateControlSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControlSite method"
ms.assetid: 9dbb47df-31ea-405c-9521-f970e4569deb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::CreateControlSite
Overridable used to create a control site instance to host a control on the form.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [COleControlContainer](../vs140/colecontrolcontainer-class.md) object containing the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a pointer to a [COleControlSite](../vs140/colecontrolsite-class.md) object, providing the site for the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The identifier of the control to be hosted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The CLSID of the control to be hosted  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 You can override this member function to return an instance of your own control site class.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)