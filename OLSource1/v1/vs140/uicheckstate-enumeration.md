---
title: "UICheckState Enumeration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "UICheckState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UICheckState enumeration"
ms.assetid: 68d84834-e7f9-4ccb-8126-d492e27073e9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UICheckState Enumeration
Describes the check state of a user interface item for the command.  
  
## Syntax  
  
```  
public enum class UICheckState  
{  
   [DefaultValue(typeid<Microsoft::VisualC::MFC::UICheckState>, "Checked")]  
   Unchecked,   
   Checked,   
   Indeterminate   
};  
```  
  
## Remarks  
 [ICommandUI::set_Check](../vs140/icommandui--check.md) uses these values to describe the state of a user interface item.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [ICommandUI Interface](../vs140/icommandui-interface.md)