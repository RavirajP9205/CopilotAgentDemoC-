# 🚀 AI-Driven C# API Generation Guide

## 📌 Purpose

This document defines a **code-generation workflow** for creating a C#
Web API using standardized practices.

This is a **demo-focused, AI-driven development flow** --- no actual
execution or dependency setup is required.

------------------------------------------------------------------------

## 🔄 Workflow Overview

Open tickets/ticket_C#_102.txt\
Generate API structure\
Generate controller + service + models\
Generate tests\
Commit & push\
Create draft PR\
Perform AI review

------------------------------------------------------------------------

## 📂 Step 1: Open Ticket

tickets/ticket_C#_102.txt

Example: Feature: Customer Profile API - Get customer details - Update
customer email - Validate input - Secure endpoint

------------------------------------------------------------------------

## 🏗️ Step 2: Generate API Structure

/Controllers\
/Services\
/Models\
/Tests\
/Constants

------------------------------------------------------------------------

## 🎯 Step 3: Generate Controller + Service + Models

### Controller

public class CustomerController : BaseApiController { }

### Service

public class CustomerService { }

### Models

public class CustomerRequest { } public class CustomerResponse { }

------------------------------------------------------------------------

## 🧪 Step 4: Generate Tests

Unit tests for controller validation and response.

------------------------------------------------------------------------

## 📤 Step 5: Commit & Push

git add .\
git commit -m "feat: Ticket ID"\
git push

------------------------------------------------------------------------

## 🔀 Step 6: Create Draft PR

Include summary and checklist.

------------------------------------------------------------------------

## 🤖 Step 7: Perform AI Review

Checklist: - BaseApiController used - Validation added - Logging
present - Try-catch implemented

------------------------------------------------------------------------

## ⚠️ Important Notes

-   Code-generation only
-   No execution required
-   Focus on AI workflow

------------------------------------------------------------------------

## ✅ Final Outcome

Open tickets/ticket_C#_102.txt\
Generate API structure\
Generate controller + service + models\
Generate tests\
Commit & push\
Create draft PR\
Perform AI review
