---
title: "Overriding a Dynamic Accessor"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accessors [C++], dynamic"
  - "dynamic accessors"
  - "overriding, dynamic accessors"
ms.assetid: cbefd156-6da5-490d-b795-c2d7d874f7ce
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overriding a Dynamic Accessor
When you use a dynamic accessor such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the command **Open** method creates an accessor for you automatically, based on the column information of the opened rowset. You can override the dynamic accessor to control exactly how the columns are bound.  
  
 To override the dynamic accessor, pass **false** as the last parameter to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method. This prevents **Open** from creating an accessor automatically. You can then call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for each column that you want to bind. The following code shows how to do it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)