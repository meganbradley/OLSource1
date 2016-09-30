---
title: "A.19   Examples Showing Incorrect Nesting of Work-sharing Directives"
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
ms.assetid: 906e900d-9259-44d6-a095-c1ba9135d269
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.19   Examples Showing Incorrect Nesting of Work-sharing Directives
The examples in this section illustrate the directive nesting rules. For more information on directive nesting, see [Section 2.9](../vs140/2.9-directive-nesting.md) on page 33.  
  
 The following example is noncompliant because the inner and outer <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directives are nested and bind to the same <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following dynamically nested version of the preceding example is also noncompliant:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example is noncompliant because the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directives are nested, and they bind to the same parallel region:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example is noncompliant because a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directive inside a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> can result in deadlock:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following example is noncompliant because the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> results in deadlock due to the fact that only one thread at a time can enter the critical section:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following example is noncompliant because the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> results in deadlock due to the fact that only one thread executes the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> section:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>