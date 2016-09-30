---
title: "Understanding Backus Nauer Form (BNF) Syntax"
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
  - "BNF notation"
  - "Backus Nauer Form (BNF) syntax"
ms.assetid: 994bbef0-9077-4aa8-bdfe-b7e830af9acc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Understanding Backus Nauer Form (BNF) Syntax
The scripts used by the ATL Registrar are described in this topic using BNF syntax, which uses the notation shown in the following table.  
  
|Convention/symbol|Meaning|  
|------------------------|-------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Equivalent|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|OR|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|One or more <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>s.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is optional. Optional delimiters are denoted by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|Any **bold** text|A string literal.|  
|Any *italicized* text|How to construct the string literal.|  
  
 As indicated in the preceding table, registrar scripts use string literals. These values are actual text that must appear in your script. The following table describes the string literals used in an ATL Registrar script.  
  
|String literal|Action|  
|--------------------|------------|  
|**ForceRemove**|Completely removes the next key (if it exists) and then re-creates it.|  
|**NoRemove**|Does not remove the next key during Unregister.|  
|**val**|Specifies that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is actually a named value.|  
|**Delete**|Deletes the next key during Register.|  
|**s**|Specifies that the next value is a string (**REG_SZ**).|  
|**d**|Specifies that the next value is a **DWORD** (**REG_DWORD**).|  
|**m**|Specifies that the next value is a multistring (**REG_MULTI_SZ**).|  
|**b**|Specifies that the next value is a binary value (**REG_BINARY**).|  
  
## BNF Syntax Examples  
 Here are a few syntax examples to help you understand how the notation and string literals work in an ATL Registrar script.  
  
### Syntax Example 1  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 specifies that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Syntax Example 2  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 specifies that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is equivalent to either <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Syntax Example 3  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 specifies that <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is equivalent to one or more <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Syntax Example 4  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 specifies that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and that the string literals, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, are optional.  
  
### Syntax Example 5  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 specifies that <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is equivalent to any non-NULL character.  
  
### Syntax Example 6  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 specifies that the key name <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a multistring value composed of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Syntax Example 7  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 specifies that the key name <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a **DWORD** value set to hexadecimal 55 (decimal 85). Note this format adheres to the **&H** notation as found in the Visual Basic specification.  
  
## See Also  
 [Creating Registrar Scripts](../vs140/creating-registrar-scripts.md)