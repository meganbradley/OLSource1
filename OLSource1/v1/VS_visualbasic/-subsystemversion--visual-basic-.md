---
title: "-subsystemversion (Visual Basic)"
ms.custom: na
ms.date: "10/07/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/subsystemversion (Visual Basic)"
helpviewer_keywords: 
  - "/subsystemversion compiler option [Visual Basic]"
  - "-subsystemversion compiler option [Visual Basic]"
  - "subsystemversion compiler option [Visual Basic]"
ms.assetid: 08be22b2-f447-4cd3-8203-120b1b920b54
caps.latest.revision: 7
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# -subsystemversion (Visual Basic)
\<?xml version="1.0" encoding="utf-8"?>
\<developerReferenceWithSyntaxDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Specifies the minimum version of the subsystem on which the generated executable file can run, thereby determining the versions of Windows on which the executable file can run. Most commonly, this option ensures that the executable file can leverage particular security features that aren’t available with older versions of Windows.</para>
    <alert class="note">
      <para>To specify the subsystem itself, use the \<legacyLink xlink:href="a18bbd8e-bbf7-49e7-992c-717d0eb1f76f">/target</legacyLink> compiler option.</para>
    </alert>
  </introduction>
  <syntaxSection>
    <legacySyntax language="vb">/subsystemversion:<parameterReference>major.minor</parameterReference></legacySyntax>
  </syntaxSection>
  <parameters>
    <content>
      <definitionTable>
        <definedTerm>
          <parameterReference>major.minor</parameterReference>
        </definedTerm>
        <definition>
          <para>The minimum required version of the subsystem, as expressed in a dot notation for major and minor versions. For example, you can specify that an application can't run on an operating system that's older than Windows 7 if you set the value of this option to 6.01, as the table later in this topic describes. You must specify the values for <parameterReference>major</parameterReference> and <parameterReference>minor</parameterReference> as integers. </para>
          <para>Leading zeroes in the <parameterReference>minor</parameterReference> version don't change the version, but trailing zeroes do. For example, 6.1 and 6.01 refer to the same version, but 6.10 refers to a different version. We recommend expressing the minor version as two digits to avoid confusion.</para>
        </definition>
      </definitionTable>
    </content>
  </parameters>
  <languageReferenceRemarks>
    <content>
      <para>The following table lists common subsystem versions of Windows.</para>
      \<table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Windows version</para>
            </TD>
            <TD>
              <para>Subsystem version</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>Windows 2000</para>
            </TD>
            <TD>
              <para>5.00</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Windows XP</para>
            </TD>
            <TD>
              <para>5.01</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Windows Server 2003</para>
            </TD>
            <TD>
              <para>5.02</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Windows Vista</para>
            </TD>
            <TD>
              <para>6.00</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Windows 7</para>
            </TD>
            <TD>
              <para>6.01</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Windows Server 2008</para>
            </TD>
            <TD>
              <para>6.01</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <token>win8</token>
              </para>
            </TD>
            <TD>
              <para>6.02</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
    <sections>
      <section>
        <title>Default values</title>
        <content>
          <para>The default value of the <system>/subsystemversion</system> compiler option depends on the conditions in the following list:</para>
          <list class="bullet">
            <listItem>
              <para>The default value is 6.02 if any compiler option in the following list is set:</para>
              <list class="bullet">
                <listItem>
                  <para>
                    \<legacyLink xlink:href="e0954147-548b-461f-9c4b-a8f88845616c">/target:appcontainerexe</legacyLink>
                  </para>
                </listItem>
                <listItem>
                  <para>
                    \<legacyLink xlink:href="e0954147-548b-461f-9c4b-a8f88845616c">/target:winmdobj</legacyLink>
                  </para>
                </listItem>
                <listItem>
                  <para>
                    \<legacyLink xlink:href="f9bc61e6-e854-4ae1-87b9-d6244de23fd1">/platform:arm</legacyLink>
                  </para>
                </listItem>
              </list>
            </listItem>
            <listItem>
              <para>The default value is 6.00 if you're using MSBuild, you're targeting <token>net_v45</token>, and you haven't set any of the compiler options that were specified earlier in this list.</para>
            </listItem>
            <listItem>
              <para>The default value is 4.00 if none of the previous conditions is true.</para>
            </listItem>
          </list>
        </content>
      </section>
      <section>
        <title>Setting this option</title>
        <content>
          <para>To set the <system>/subsystemversion</system> compiler option in Visual Studio, you must open the .vbproj file and specify a value for the <languageKeyword>SubsystemVersion</languageKeyword> property in the MSBuild XML. You can't set this option in the Visual Studio IDE. For more information, see "Default values" earlier in this topic or \<link xlink:href="9857505d-ae15-42f1-936d-6cd7fb9dd276">Common MSBuild Project Properties</link>.</para>
			  <para>"MSBuild Properties"</para>
        </content>
      </section>
    </sections>
  </languageReferenceRemarks>
  <relatedTopics>
    \<link xlink:href="6b57c444-50c7-4b88-8f59-ed65cff5e05c">Visual Basic Command-Line Compiler</link>
</relatedTopics>
</developerReferenceWithSyntaxDocument>