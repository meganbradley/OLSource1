---
title: "COleCurrency::ParseCurrency"
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
  - "COleCurrency.ParseCurrency"
  - "COleCurrency::ParseCurrency"
  - "ParseCurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ParseCurrency method"
ms.assetid: 92a06ce9-0186-4286-a3c4-179021833fc6
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::ParseCurrency
Call this member function to parse a string to read a currency value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpszCurrency*  
 A pointer to the null-terminated string which is to be parsed.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates flags for locale settings, possibly the following flag:  
  
-   **LOCALE_NOUSEROVERRIDE** Use the system default locale settings, rather than custom user settings.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
## Return Value  
 Nonzero if the string was successfully converted to a currency value, otherwise 0.  
  
## Remarks  
 It uses local language specifications (locale IDs) for the meaning of nonnumeric characters in the source string.  
  
 For a discussion of locale ID values, see [Supporting Multiple Languages](assetId:///47dc5add-232c-4268-b977-43e12da81ede).  
  
 If the string was successfully converted to a currency value, the value of this **COleCurrency** object is set to that value and its status to valid.  
  
 If the string could not be converted to a currency value or if there was a numerical overflow, the status of this **COleCurrency** object is invalid.  
  
 If the string conversion failed due to memory allocation errors, this function throws a [CMemoryException](../vs140/cmemoryexception-class.md). In any other error state, this function throws a [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#13](../vs140/codesnippet/CPP/colecurrency--parsecurrency_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::Format](../vs140/colecurrency--format.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)