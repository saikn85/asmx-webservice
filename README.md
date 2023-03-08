# Learning ASP.NET Web Service (ASMX)

## Introduction

**Web services** are a standardized way for developing interoperable applications i.e enabling an application to invoke a method of another application.
These applications can be on the same computer or different computers. Web services use open standards and protocols like HTTP, XML and SOAP.
Since these are open and well known protocols, applications built on any platform can interoperate with web services.
For example, a JAVA application can interoperate with a web service built using .NET.
Similarly a web service built using JAVA can be consumed by a .NET application.

**Hyper Text Transfer Protocol (HTTP)** is the protocl widely used by web services to send and receive messages.
The messaging protocol is SOAP. SOAP stands for Simple Object Access Protocol. SOAP messages are in XML format.

## Simple Object Access Protocol (SOAP)

A SOAP message is an XML document containing the following elements:

- A root element named Envelope that identifies the XML document as a SOAP message.
- An optional Header element that contains application-specific information such as authentication data. If the Header element is present it must be the first child element of the Envelope element.
- A required Body element that contains the SOAP message intended for the recipient.
- An optional Fault element that's used to indicate error messages. If the Fault element is present, it must be a child element of the Body element.

SOAP can operate over many transport protocols, including HTTP, SMTP, TCP, and UDP.

***However, an ASMX service can only operate over HTTP.***