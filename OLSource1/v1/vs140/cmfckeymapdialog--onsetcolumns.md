---
title: "CMFCKeyMapDialog::OnSetColumns"
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
  - "OnSetColumns"
  - "CMFCKeyMapDialog.OnSetColumns"
  - "CMFCKeyMapDialog::OnSetColumns"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetColumns method"
ms.assetid: 1f270ad4-8b2c-4bfa-9353-d0c85e0eeeb3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::OnSetColumns
Called by the framework to set captions for the columns in the internal list control that supports the keyboard mapping control.  
  
## Syntax  
  
```  
virtual void OnSetColumns();  
```  
  
## Remarks  
 By default, this method obtains the captions for the columns from three resources. The command column caption is from IDS_AFXBARRES_COMMAND, the key column caption is from IDS_AFXBARRES_KEYS, and the description column caption is from IDS_AFXBARRES_DESCRIPTION.  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)