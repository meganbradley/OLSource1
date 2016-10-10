---
title: "Command-line Building With csc.exe"
ms.custom: na
ms.date: "10/10/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "CSharp"
helpviewer_keywords: 
  - "builds [C#]"
  - "command line [C#]"
ms.assetid: 66e70056-dd20-453c-a9b3-507e0478b015
caps.latest.revision: 26
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
# Command-line Building With csc.exe
\<?xml version="1.0" encoding="utf-8"?>
\<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>You can invoke the C# compiler by typing the name of its executable file (csc.exe) at a command prompt.</para>
    <para>If you use the <ui>Visual Studio Command Prompt</ui> window, all the necessary environment variables are set for you. In Windows 7, you can access that window from the <ui>Start</ui> menu by opening the Microsoft Visual Studio <placeholder>Version</placeholder>\Visual Studio Tools folder. In Windows 8, the Visual Studio Command Prompt is called the <ui>Developer Command Prompt for VS2012</ui>, and you can find it by searching from the Start screen.</para>
    <para>If you use a standard Command Prompt window, you must adjust your path before you can invoke csc.exe from any subdirectory on your computer. You also must run vsvars32.bat to set the appropriate environment variables to support command-line builds. For more information about vsvars32.bat, including instructions for how to find and run it, see \<link xlink:href="7EC09480-5612-4F6A-8D00-AD90EA9BCA5D">How to: Set Environment Variables</link>.</para>
    <para>If you're working on a computer that has only the <token>winsdklong</token>, you can use the C# compiler at the <ui>SDK Command Prompt</ui>, which you open from the <ui>Microsoft .NET Framework SDK</ui> menu option.</para>
    <para>You can also use MSBuild to build C# programs programmatically. For more information, see MSBuild.</para>
    <para>The csc.exe executable file usually is located in the Microsoft.NET\Framework\<placeholder>Version</placeholder> folder under the Windows directory. Its location might vary depending on the exact configuration of a particular computer. If more than one version of the .NET Framework is installed on your computer, you'll find multiple versions of this file. For more information about such installations, see \<legacyLink xlink:href="1A87CC6A-1C4B-4C38-B878-FAA9B3BEAE3C">Determining Which Version of the .NET Framework Is Installed</legacyLink>.</para>
    <alert class="tip">
      <para>When you build a project by using the Visual Studio IDE, you can display the <ui>csc</ui> command and its associated compiler options in the <ui>Output</ui> window. To display this information, follow the instructions in \<link xlink:href="75d38b76-26d6-4f43-bbe7-cbacd7cc81e7">How to: View, Save, and Configure Build Log Files</link> to change the verbosity level of the log data to <ui>Normal</ui> or <ui>Detailed</ui>. After you rebuild your project, search the <ui>Output</ui> window for <ui>csc</ui> to find the invocation of the C# compiler.</para>
    </alert>
    <para>
      <embeddedLabel>In this topic</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>
          \<legacyLink xlink:href="#vcconcommand-linebuildinganchor1">Rules for Command-Line Syntax</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          \<legacyLink xlink:href="#vcconcommand-linebuildinganchor2">Sample Command Lines</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          \<legacyLink xlink:href="#vcconcommand-linebuildinganchor3">Differences Between C# Compiler and C++ Compiler Output</legacyLink>
        </para>
      </listItem>
    </list>
  </introduction>
  <section address="vcconcommand-linebuildinganchor1">
    <title>Rules for Command-Line Syntax for the C# Compiler</title>
    <content>
      <para>The C# compiler uses the following rules when it interprets arguments given on the operating system command line:</para>
      <list class="bullet">
        <listItem>
          <para>Arguments are delimited by white space, which is either a space or a tab.</para>
        </listItem>
        <listItem>
          <para>The caret character (^) is not recognized as an escape character or delimiter. The character is handled by the command-line parser in the operating system before it is passed to the argv array in the program.</para>
        </listItem>
        <listItem>
          <para>A string enclosed in double quotation marks ("string") is interpreted as a single argument, regardless of white space that is contained within. A quoted string can be embedded in an argument.</para>
        </listItem>
        <listItem>
          <para>A double quotation mark preceded by a backslash (\") is interpreted as a literal double quotation mark character (").</para>
        </listItem>
        <listItem>
          <para>Backslashes are interpreted literally, unless they immediately precede a double quotation mark.</para>
        </listItem>
        <listItem>
          <para>If an even number of backslashes is followed by a double quotation mark, one backslash is put in the argv array for every pair of backslashes, and the double quotation mark is interpreted as a string delimiter.</para>
        </listItem>
        <listItem>
          <para>If an odd number of backslashes is followed by a double quotation mark, one backslash is put in the argv array for every pair of backslashes, and the double quotation mark is "escaped" by the remaining backslash. This causes a literal double quotation mark (") to be added in argv.</para>
        </listItem>
      </list>
    </content>
  </section>
  <section address="vcconcommand-linebuildinganchor2">
    <title>Sample Command Lines for the C# Compiler</title>
    <content>
      <list class="bullet">
        <listItem>
          <para>Compiles File.cs producing File.exe: </para>
          <code>csc File.cs </code>
        </listItem>
        <listItem>
          <para>Compiles File.cs producing File.dll: </para>
          <code>csc /target:library File.cs</code>
        </listItem>
        <listItem>
          <para>Compiles File.cs and creates My.exe: </para>
          <code>csc /out:My.exe File.cs</code>
        </listItem>
        <listItem>
          <para>Compiles all the C# files in the current directory, with optimizations on and defines the DEBUG symbol. The output is File2.exe: </para>
          <code>csc /define:DEBUG /optimize /out:File2.exe *.cs</code>
        </listItem>
        <listItem>
          <para>Compiles all the C# files in the current directory producing a debug version of File2.dll. No logo and no warnings are displayed: </para>
          <code>csc /target:library /out:File2.dll /warn:0 /nologo /debug *.cs</code>
        </listItem>
        <listItem>
          <para>Compiles all the C# files in the current directory to Something.xyz (a DLL): </para>
          <code>csc /target:library /out:Something.xyz *.cs</code>
        </listItem>
      </list>
    </content>
  </section>
  <section address="vcconcommand-linebuildinganchor3">
    <title>Differences Between C# Compiler and C++ Compiler Output</title>
    <content>
      <para>There are no object (.obj) files created as a result of invoking the C# compiler; output files are created directly. As a result of this, the C# compiler does not need a linker.</para>
    </content>
  </section>
  <relatedTopics>
    \<link xlink:href="D3403556-1816-4546-A782-E8223A772E44">C# Compiler Options</link>
\<link xlink:href="43535EA0-CA47-4A15-B528-615087A86092">C# Compiler Options Listed Alphabetically</link>
\<link xlink:href="96437ECC-6502-4CD3-B070-E9386A298E83">C# Compiler Options Listed by Category</link>\<link xlink:href="73a17231-cf96-44ea-aa8a-54807c6fb1f4">Main() and Command-Line Arguments (C# Programming Guide)</link>\<link xlink:href="0e597e0d-ea7a-41ba-a38a-0198122f3c26">Command-Line Arguments (C# Programming Guide)</link>\<link xlink:href="b8479f2d-9e05-4d38-82da-2e61246e5437">How to: Display Command Line Arguments (C# Programming Guide)</link>\<link xlink:href="89c3e335-3f5b-4e24-8c5a-b8036561fe8a">How to: Access Command-Line Arguments Using foreach (C# Programming Guide)</link>\<link xlink:href="c2f5a1d8-1676-4bea-bc7e-44a97e72d5bc">Main() Return Values (C# Programming Guide)</link></relatedTopics>
</developerConceptualDocument>