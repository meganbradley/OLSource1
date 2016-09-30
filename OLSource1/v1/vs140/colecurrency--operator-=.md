---
title: "COleCurrency::operator ="
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
  - "COleCurrency.operator="
  - "COleCurrency::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, currency"
  - "operator=, currency"
  - "= operator, with specific MFC objects"
  - "COleCurrency class, operators"
ms.assetid: 11b906ce-0840-49f5-9ba2-2846fb257ade
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::operator =
These overloaded assignment operators copy the source currency value into this **COleCurrency** object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A brief description of each operator follows:  
  
-   **operator =(**  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  **)** The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value is copied into the **COleCurrency** object and its status is set to valid.  
  
-   **operator =(**  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  **)** The value and status of the operand, an existing **COleCurrency** object are copied into this **COleCurrency** object.  
  
-   **operator =(**  *varSrc*  **)** If the conversion of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value (or [COleVariant](../vs140/colevariant-class.md) object) to a currency (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) is successful, the converted value is copied into this **COleCurrency** object and its status is set to valid. If the conversion is not successful, the value of the **COleCurrency** object is set to 0 and its status to invalid.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) and [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCOleContainer#15](../vs140/codesnippet/CPP/colecurrency--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::COleCurrency](../vs140/colecurrency--colecurrency.md)   
 [COleCurrency::SetCurrency](../vs140/colecurrency--setcurrency.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)