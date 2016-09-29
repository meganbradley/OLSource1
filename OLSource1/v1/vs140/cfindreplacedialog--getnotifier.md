---
title: "CFindReplaceDialog::GetNotifier"
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
  - "GetNotifier"
  - "CFindReplaceDialog.GetNotifier"
  - "CFindReplaceDialog::GetNotifier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFindReplaceDialog class, operations"
  - "GetNotifier method"
ms.assetid: ef19f6ee-b14a-41da-80c8-a01f2b1d3069
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::GetNotifier
Call this function to retrieve a pointer to the current Find Replace dialog box.  
  
## Syntax  
  
```  
  
      static CFindReplaceDialog* PASCAL GetNotifier(  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `lParam`  
 The **lparam** value passed to the frame window's **OnFindReplace** member function.  
  
## Return Value  
 A pointer to the current dialog box.  
  
## Remarks  
 It should be used within your callback function to access the current dialog box, call its member functions, and access the `m_fr` structure.  
  
## Example  
 See [CFindReplaceDialog::Create](../vs140/cfindreplacedialog--create.md) for an example of how to register the OnFindReplace handler to receive notifications from the Find Replace dialog box.  
  
 [!code[NVC_MFCDocView#69](../vs140/codesnippet/CPP/cfindreplacedialog--getnotifier_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)