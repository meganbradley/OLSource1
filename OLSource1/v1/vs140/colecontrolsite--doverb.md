---
title: "COleControlSite::DoVerb"
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
  - "COleControlSite.DoVerb"
  - "COleControlSite::DoVerb"
  - "DoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "DoVerb method"
ms.assetid: 21a71d47-5efb-4005-95fc-a2fa832c7ec0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::DoVerb
Executes the specified verb.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the verb to execute. It can include one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|0|Primary verb|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|-1|Secondary verb|(None)|  
|1|Displays the object for editing.|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|-2|Edits the item in a separate window.|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|-3|Hides the object.|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|-4|Activates a control in-place.|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|-5|Activates a control in-place, without additional user interface elements.|**OLEIVERB_INPLACEACTIVATE**|  
|-7|Display the control's properties.|**OLEIVERB_PROPERTIES**|  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the message that caused the item to be activated.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value.  
  
## Remarks  
 This function directly calls through the control's <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface to execute the specified verb. If an exception is thrown as a result of this function call, an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> error code is returned.  
  
 For more information, see [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)