---
title: "CComMultiThreadModelNoCS::ThreadModelNoCS"
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
  - "ThreadModelNoCS"
  - "CComMultiThreadModelNoCS::ThreadModelNoCS"
  - "CComMultiThreadModelNoCS.ThreadModelNoCS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThreadModelNoCS typedef"
ms.assetid: 5dec6e36-0742-457e-acaa-1a820d751d3b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModelNoCS::ThreadModelNoCS
When using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> simply references <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the class referenced by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
 Note that the definition of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> provides symmetry with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For example, suppose the sample code in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> declared the following <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
 [!code[NVC_ATL_COM#37](../vs140/codesnippet/CPP/ccommultithreadmodelnocs--threadmodelnocs_1.h)]  
  
 Regardless of the class specified for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (such as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> resolves accordingly.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModelNoCS Class](../vs140/ccommultithreadmodelnocs-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)