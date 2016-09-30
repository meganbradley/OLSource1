---
title: "Operators.Checked Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Operators.Checked"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Checked"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Checked module [F#]"
ms.assetid: 6e3326ec-0f93-4ab9-ae33-235ab6eb0028
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.Checked Module (F#)
This module contains the basic arithmetic operations with overflow checks.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[( * )](../vs140/checked.------^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Overloaded multiplication operator (checks for overflow).|  
|[( + )](../vs140/checked.------^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Overloaded addition operator (checks for overflow).|  
|[( - )](../vs140/checked.------^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Overloaded subtraction operator (checks for overflow).|  
|[( ~- )](../vs140/checked.--~----^t--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Overloaded unary negation (checks for overflow).|  
|[byte](../vs140/checked.byte-^t--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Byte.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[char](../vs140/checked.char-^t--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Numeric inputs are converted using a checked conversion according to the UTF-16 encoding for characters. String inputs must be exactly one character long. For other input types the operation requires an appropriate static conversion method on the input type.|  
|[int](../vs140/checked.int-^t--function--fsharp-.md)  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int32.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int16](../vs140/checked.int16-^t--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int16.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int32](../vs140/checked.int32-^t--function--fsharp-.md)  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int32.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int64](../vs140/checked.int64-^t--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int64.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[nativeint](../vs140/checked.nativeint-^t--function--fsharp-.md)  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[sbyte](../vs140/checked.sbyte-^t--function--fsharp-.md)  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.SByte.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint16](../vs140/checked.uint16-^t--function--fsharp-.md)  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt16.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint32](../vs140/checked.uint32-^t--function--fsharp-.md)  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt32.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint64](../vs140/checked.uint64-^t--function--fsharp-.md)  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt64.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../vs140/checked.unativeint-^t--function--fsharp-.md)  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Converts the argument to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. This is a direct, checked conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)