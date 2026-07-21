# Energy Management System (EMS) ⚡

A comprehensive, full-stack industrial web application designed to monitor, analyze, and optimize high-frequency energy consumption data from plant floor machinery. 

This project bridges the gap between Operational Technology (OT) and Information Technology (IT), capturing raw telemetry from L1 PLCs and transforming it into real-time, actionable intelligence for enterprise stakeholders.

## 📸 Project Dashboards

### Real-Time Monitoring & KPIs
<img width="683" height="359" alt="image" src="https://github.com/user-attachments/assets/e0a505c7-a28c-442c-9b28-77dbd5b84eaa" />

*Displays live daily consumption, monthly tracking, and comparison metrics across different facility meters.*

### Process Control & Anomaly Detection
<img width="680" height="377" alt="image" src="https://github.com/user-attachments/assets/4bfb4c6a-33ff-41d7-986c-b1d206519a5d" />

*Interactive Process Control Chart highlighting Upper/Lower Specification Limits (USL/LSL) and conditional data grids for immediate anomaly flagging.*

### Database Architecture & Telemetry Ingestion
### Microsoft SQL Server
<img width="670" height="377" alt="image" src="https://github.com/user-attachments/assets/ece84cc2-512f-4cba-93e3-8d43292a3aaa" />

### Google Big Query
<img width="1919" height="992" alt="image" src="https://github.com/user-attachments/assets/5fc67fd6-356d-4a8a-96bc-0d334a87876d" />
<img width="1919" height="990" alt="image" src="https://github.com/user-attachments/assets/0db79d08-9872-44e1-b1be-609fe3bfc2ad" />



*Demonstrates the structured querying of relational metadata and time-series telemetry data using Microsoft SQL Server.*

## 🛠️ Technology Stack
* **Frontend:** ASP.NET Web Application (MVC), HTML/CSS, Bootstrap, JavaScript, Chart.js
* **Backend:** ASP.NET Core Web API, C#
* **Database:** Microsoft SQL Server (MSSQL), advanced T-SQL (Stored Procedures, Triggers, Views)
* **Industrial Protocols:** OPC DA (Data Access)
* **Cloud & Analytics:** Google Cloud Platform (BigQuery), Looker Studio

## 🚀 Key Features
* **OT-IT Integration:** Secure unidirectional pipeline pulling L1 machine data into L3 enterprise servers.
* **Hybrid Database Strategy:** Optimized MSSQL schema to handle rapid time-series data ingestion alongside relational meter metadata.
* **Dynamic Visualizations:** Automated plotting of machine telemetry against safety thresholds to detect operational anomalies.
* **API Architecture:** Decoupled backend using ASP.NET Core API to serve aggregated JSON data securely to the frontend dashboard.
* **Cloud-Ready:** Architecture designed for secondary data migration to Google BigQuery for highly scalable, serverless historical analytics.

## 👨‍💻 About This Project
This system was developed during the **TATA Prashikshan Internship Programme** under the Automation Division at TATA STEEL Limited, Jamshedpur. 

*Note: Due to confidentiality and local network dependencies (OPC servers, live PLC feeds), this repository contains the structural source code. The live application requires the corresponding local database and industrial network configuration to execute fully.*
