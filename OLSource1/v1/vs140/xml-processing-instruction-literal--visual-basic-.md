---
title: "XML Processing Instruction Literal (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.XmlLiteralProcessingInstruction
dev_langs: 
  - VB
helpviewer_keywords: 
  - XML literals [Visual Basic], processing instruction
  - XML processing instruction literal [Visual Basic]
  - processing instruction literal [Visual Basic]
ms.assetid: cef4f7f8-0011-4f64-8602-795077ad4f15
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# XML Processing Instruction Literal (Visual Basic)
A literal representing an <xref:System.Xml.Linq.XProcessingInstruction?qualifyHint=False> object.  
  
## Syntax  
  
```  
<?piName [ = piData ] ?>  
```  
  
## Parts  
 `<?`  
 Required. Denotes the start of the XML processing instruction literal.  
  
 `piName`  
 Required. Name indicating which application the processing instruction targets. Cannot begin with "xml" or "XML".  
  
 `piData`  
 Optional. String indicating how the application targeted by `piName` should process the XML document.  
  
 `?>`  
 Required. Denotes the end of the processing instruction.  
  
## Return Value  
 An <xref:System.Xml.Linq.XProcessingInstruction?qualifyHint=False> object.  
  
## Remarks  
 XML processing instruction literals indicate how applications should process an XML document. When an application loads an XML document, the application can check the XML processing instructions to determine how to process the document. The application interprets the meaning of `piName` and `piData`.  
  
 The XML document literal uses syntax that is similar to that of the XML processing instruction. For more information, see [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md).  
  
> [!NOTE]
>  The `piName` element cannot begin with the strings "xml" or "XML", because the XML 1.0 specification reserves those identifiers.  
  
 You can assign an XML processing instruction literal to a variable or include it in an XML document literal.  
  
> [!NOTE]
>  An XML literal can span multiple lines without needing line continuation characters. This enables you to copy content from an XML document and paste it directly into a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts the XML processing instruction literal to a call to the <xref:System.Xml.Linq.XProcessingInstruction.#ctor?qualifyHint=False> constructor.  
  
## Example  
 The following example creates a processing instruction identifying a style-sheet for an XML document.  
  
 [!code[VbXMLSamples#28](../vs140/codesnippet/VisualBasic/xml-processing-instruction-literal--visual-basic-_1.vb)]
  
  
## See Also  
 <xref:System.Xml.Linq.XProcessingInstruction?qualifyHint=False>   
 [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)