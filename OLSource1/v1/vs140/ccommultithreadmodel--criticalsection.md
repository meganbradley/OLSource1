---
title: "CComMultiThreadModel::CriticalSection"
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
  - "CComMultiThreadModel::CriticalSection"
  - "CComMultiThreadModel.CriticalSection"
  - "CriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSection typedef"
ms.assetid: ecf6edcb-a1cd-4054-800c-5f2614e9b9f3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModel::CriticalSection
When using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> references class [CComCriticalSection](../vs140/ccomcriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) also contain definitions for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> name [AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md). You should not specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModel Class](../vs140/ccommultithreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComMultiThreadModel::ThreadModelNoCS](../vs140/ccommultithreadmodel--threadmodelnocs.md)