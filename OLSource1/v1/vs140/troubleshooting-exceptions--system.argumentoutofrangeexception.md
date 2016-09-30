---
title: "Troubleshooting Exceptions: System.ArgumentOutOfRangeException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ArgumentOutOfRangeException class"
ms.assetid: f53c58d9-7c4e-407f-93d3-1e59d90d98f5
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.ArgumentOutOfRangeException
An \<xref:System.ArgumentOutOfRangeException*> is thrown when a method is invoked and at least one of the arguments passed to the method is not a null reference (`Nothing` in Visual Basic) and does not contain a valid value.  
  
## Associated Tips  
 **Make sure all arguments to this method have valid values as defined by the invoked method.**  
 Arguments that are not null references must contain valid values.  
  
 **If you are working with a collection, make sure that the index is less than the size of the collection.**  
 The index must be within the size range of the collection and cannot exceed the size range or be less than zero. For more information, see [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md).  
  
 **When using the overloaded two-argument FindString or FindStringExact methods of the ComboBox or ListBox class, check the startIndex parameter**.  
 This exception may be thrown if `startIndex` is equal to the index value of the last item of the associated list. To work around this, pass 0 as the `startIndex` parameter or use the one-argument `FindString` or `FindStringExact` method. For more information, see [CComboBox::FindString](../vs140/ccombobox--findstring.md) or [CListBox::FindString](../vs140/clistbox--findstring.md).  
  
## See Also  
 \<xref:System.ArgumentOutOfRangeException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)