---
title: "How to: Convert a byte Array to an int (C# Programming Guide)"
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
  - "CSharp"
helpviewer_keywords: 
  - "conversions [C#], byte array to int"
  - "byte arrays [C#], converting to int"
ms.assetid: d6ac20e2-448e-4aea-99b9-faf04c6f1e79
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert a byte Array to an int (C# Programming Guide)
This example shows you how to use the \<xref:System.BitConverter*> class to convert an array of bytes to an [int](../vs140/int--csharp-reference-.md) and back to an array of bytes. You may have to convert from bytes to a built-in data type after you read bytes off the network, for example. In addition to the [ToInt32(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt32(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False) method in the example, the following table lists methods in the \<xref:System.BitConverter*> class that convert bytes (from an array of bytes) to other built-in types.  
  
|Type returned|Method|  
|-------------------|------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|[ToBoolean(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToBoolean(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|[ToChar(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToChar(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|[ToDouble(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToDouble(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[ToInt16(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt16(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|[ToInt32(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt32(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[ToInt64(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt64(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[ToSingle(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToSingle(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[ToUInt16(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToUInt16(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[ToUInt32(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToUInt32(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[ToUInt64(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToUInt64(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False)|  
  
## Example  
 This example initializes an array of bytes, reverses the array if the computer architecture is little-endian (that is, the least significant byte is stored first), and then calls the [ToInt32(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt32(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False) method to convert four bytes in the array to an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The second argument to [ToInt32(Byte\[\], Int32)](assetId:///M:System.BitConverter.ToInt32(System.Byte[],System.Int32)?qualifyHint=False&autoUpgrade=False) specifies the start index of the array of bytes.  
  
> [!NOTE]
>  The output may differ depending on the endianess of your computer's architecture.  
  
 [!code[csProgGuideTypes#22](../vs140/codesnippet/CSharp/how-to--convert-a-byte-array-to-an-int--csharp-programming-guide-_1.cs)]  
  
## Example  
 In this example, the \<xref:System.BitConverter.GetBytes(System.Int32)> method of the \<xref:System.BitConverter*> class is called to convert an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to an array of bytes.  
  
> [!NOTE]
>  The output may differ depending on the endianess of your computer's architecture.  
  
 [!code[csProgGuideTypes#23](../vs140/codesnippet/CSharp/how-to--convert-a-byte-array-to-an-int--csharp-programming-guide-_2.cs)]  
  
## See Also  
 \<xref:System.BitConverter*>   
 \<xref:System.BitConverter.IsLittleEndian*>   
 [Data Types](../vs140/types--csharp-programming-guide-.md)