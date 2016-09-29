---
title: "DEVMODE and TEXTMETRIC String Conversion Macros"
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
  - "TEXTMETRICW2A"
  - "TEXTMETRIC"
  - "TEXTMETRICT2OLE"
  - "DEVMODE"
  - "DEVMODEOLE2T"
  - "TEXTMETRICOLE2T"
  - "DEVMODEW2A"
  - "DEVMODET2OLE"
  - "TEXTMETRICA2W"
  - "DEVMODEA2W"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TEXTMETRICA2W macro"
  - "TEXTMETRICOLE2T macro"
  - "string conversion, string conversion macros"
  - "ATL, string conversion macros"
  - "text, conversion macros"
  - "TEXTMETRIC macro"
  - "DEVMODEW2A macro"
  - "TEXTMETRICT2OLE macro"
  - "DEVMODE macro"
  - "DEVMODEOLE2T macro"
  - "TEXTMETRICW2A macro"
  - "DEVMODEA2W macro"
  - "DEVMODET2OLE macro"
ms.assetid: 85cebec0-2a18-48e5-9c1c-99d5b7f15425
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DEVMODE and TEXTMETRIC String Conversion Macros
These macros create a copy of a [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) or [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure and convert the strings within the new structure to a new string type. The macros allocate memory on the stack for the new structure and return a pointer to the new structure.  
  
## Syntax  
  
```  
  
      MACRONAME(   
   address_of_structure    
)  
```  
  
## Remarks  
 For example:  
  
 [!code[NVC_ATL_Utilities#128](../vs140/codesnippet/CPP/devmode-and-textmetric-string-conversion-macros_1.cpp)]  
  
 and:  
  
 [!code[NVC_ATL_Utilities#129](../vs140/codesnippet/CPP/devmode-and-textmetric-string-conversion-macros_2.cpp)]  
  
 In the macro names, the string type in the source structure is on the left (for example, **A**) and the string type in the destination structure is on the right (for example, **W**). **A** stands for **LPSTR**, **OLE** stands for `LPOLESTR`, **T** stands for `LPTSTR`, and **W** stands for `LPWSTR`.  
  
 Thus, `DEVMODEA2W` copies a `DEVMODE` structure with **LPSTR** strings into a `DEVMODE` structure with `LPWSTR` strings, `TEXTMETRICOLE2T` copies a `TEXTMETRIC` structure with `LPOLESTR` strings into a `TEXTMETRIC` structure with `LPTSTR` strings, and so on.  
  
 The two strings converted in the `DEVMODE` structure are the device name (**dmDeviceName**) and the form name (**dmFormName**). The `DEVMODE` string conversion macros also update the structure size (**dmSize**).  
  
 The four strings converted in the `TEXTMETRIC` structure are the first character (**tmFirstChar**), the last character (**tmLastChar**), the default character (**tmDefaultChar**), and the break character (**tmBreakChar**).  
  
 The behavior of the `DEVMODE` and `TEXTMETRIC` string conversion macros depends on the compiler directive in effect, if any. If the source and destination types are the same, no conversion takes place. Compiler directives change **T** and **OLE** as follows:  
  
|Compiler directive in effect|T becomes|OLE becomes|  
|----------------------------------|---------------|-----------------|  
|none|**A**|**W**|  
|**_UNICODE**|**W**|**W**|  
|**OLE2ANSI**|**A**|**A**|  
|**_UNICODE** and **OLE2ANSI**|**W**|**A**|  
  
 The following table lists the `DEVMODE` and `TEXTMETRIC` string conversion macros.  
  
### DEVMODE and TEXTMETRIC String Conversion Macros  
  
|||  
|-|-|  
|`DEVMODEA2W`|`TEXTMETRICA2W`|  
|`DEVMODEOLE2T`|`TEXTMETRICOLE2T`|  
|`DEVMODET2OLE`|`TEXTMETRICT2OLE`|  
|`DEVMODEW2A`|`TEXTMETRICW2A`|  
  
## See Also  
 [Macros](../vs140/atl-macros.md)   
 [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md)