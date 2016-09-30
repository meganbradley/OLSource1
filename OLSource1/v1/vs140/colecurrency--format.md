---
title: "COleCurrency::Format"
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
  - "COleCurrency::Format"
  - "COleCurrency.Format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Format method"
ms.assetid: 3807eb9a-8785-4993-8e5a-09ac59793eda
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::Format
Call this member function to create a formatted representation of the currency value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates flags for locale settings. Only the following flag is relevant to currency:  
  
-   **LOCALE_NOUSEROVERRIDE** Use the system default locale settings, rather than custom user settings.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that contains the formatted currency value.  
  
## Remarks  
 It formats the value using the local language specifications (locale IDs). A currency symbol is not included in the value returned. If the status of this **COleCurrency** object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource **IDS_INVALID_CURRENCY**.  
  
## Example  
 [!code[NVC_MFCOleContainer#11](../vs140/codesnippet/CPP/colecurrency--format_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::ParseCurrency](../vs140/colecurrency--parsecurrency.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)