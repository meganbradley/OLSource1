---
title: "CBitmapButton::AutoLoad"
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
  - "CBitmapButton::AutoLoad"
  - "AutoLoad"
  - "CBitmapButton.AutoLoad"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBitmapButton class, construction/destruction"
  - "AutoLoad method"
ms.assetid: 297ce926-182e-4662-9bee-f21e80633b65
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmapButton::AutoLoad
Associates a button in a dialog box with an object of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class, loads the bitmap(s) by name, and sizes the button to fit the bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The button's control ID.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the object that owns the button.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function to initialize an owner-draw button in a dialog box as a bitmap button. Instructions for using this function are in the remarks for the [CBitmapButton](../vs140/cbitmapbutton-class.md) class.  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#75](../vs140/codesnippet/CPP/cbitmapbutton--autoload_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CBitmapButton Class](../vs140/cbitmapbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmapButton::LoadBitmaps](../vs140/cbitmapbutton--loadbitmaps.md)   
 [CBitmapButton::SizeToContent](../vs140/cbitmapbutton--sizetocontent.md)