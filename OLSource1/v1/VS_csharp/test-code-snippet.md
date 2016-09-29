---
title: "test code snippet"
ms.custom: na
ms.date: "09/23/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f2794049-c553-4187-9d6a-64eeca70570d
caps.latest.revision: 2
ms.author: "terryjin"
---
# test code snippet
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Concatenation operators join multiple strings into a single string. There are two concatenation operators, <languageKeyword>+</languageKeyword> and <languageKeyword>&amp;</languageKeyword>. Both carry out the basic concatenation operation, as the following example shows.</para>
    <codeReference>Dim x As String = "Mic" &amp; "ro" &amp; "soft" Dim y As String = "Mic" + "ro" + "soft" ' The preceding statements set both x and y to "Microsoft".</codeReference>
    <para>These operators can also concatenate <languageKeyword>String</languageKeyword> variables, as the following example shows.</para>
    <codeReference>VbVbalrOperators#76</codeReference>
  </introduction>
  <section>
    <title>Differences Between the Two Concatenation Operators</title>
    <content>
      <para>The <legacyLink xlink:href="5694778f-0a2c-4539-8009-f66f318fb46d">+ Operator (Visual Basic)</legacyLink> has the primary purpose of adding two numbers. However, it can also concatenate numeric operands with string operands. The <languageKeyword>+</languageKeyword> operator has a complex set of rules that determine whether to add, concatenate, signal a compiler error, or throw a run-time <codeEntityReference autoUpgrade="true">T:System.InvalidCastException</codeEntityReference> exception.</para>
      <para>The <link xlink:href="FEFC3D00-CBF1-475C-8C5E-6FB213B3F85A">&amp; Operator (Visual Basic)</link> is defined only for <languageKeyword>String</languageKeyword> operands, and it always widens its operands to <languageKeyword>String</languageKeyword>, regardless of the setting of <languageKeyword>Option Strict</languageKeyword>. The <languageKeyword>&amp;</languageKeyword> operator is recommended for string concatenation because it is defined exclusively for strings and reduces your chances of generating an unintended conversion.</para>
    </content>
  </section>
  <section>
    <title>Performance: String and StringBuilder</title>
    <content>
      <para>If you do a significant number of manipulations on a string, such as concatenations, deletions, and replacements, your performance might profit from the <codeEntityReference autoUpgrade="true">T:System.Text.StringBuilder</codeEntityReference> class in the <codeEntityReference autoUpgrade="true">N:System.Text</codeEntityReference> namespace. It takes an extra instruction to create and initialize a <codeEntityReference autoUpgrade="true">T:System.Text.StringBuilder</codeEntityReference> object, and another instruction to convert its final value to a <languageKeyword>String</languageKeyword>, but you might recover this time because <codeEntityReference autoUpgrade="true">T:System.Text.StringBuilder</codeEntityReference> can perform faster.</para>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="5883E0C1-A920-4274-8E46-B0FF047EAEE5">Option Strict Statement</link>
<legacyLink xlink:href="905055cd-7f50-48fb-9eed-b0995af1dc1f">Types of String Manipulation Methods in Visual Basic</legacyLink>
<legacyLink xlink:href="325dac7a-ea4f-41d5-8b48-f6e904211569">Arithmetic Operators in Visual Basic</legacyLink>
<legacyLink xlink:href="0b570339-5407-474f-8421-e183a8b303ee">Comparison Operators in Visual Basic</legacyLink>
<legacyLink xlink:href="ca474e13-567d-4b1d-a18b-301433705e57">Logical and Bitwise Operators in Visual Basic</legacyLink>
</relatedTopics>
</developerConceptualDocument>