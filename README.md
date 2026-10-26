# 🛒 QA Automation Portfolio - .NET & Playwright

Este repositorio contiene un proyecto de automatización de pruebas End-to-End (E2E) desarrollado como parte de mi portafolio profesional. El objetivo es demostrar buenas prácticas de automatización utilizando un stack moderno en el ecosistema .NET.

## 🛠️ Tecnologías utilizadas
- **Lenguaje:** C# (.NET 10)
- **Framework de Automatización:** Playwright
- **Framework de Pruebas:** NUnit
- **Patrón de Diseño:** Page Object Model (POM)
- **CI/CD:** GitHub Actions

## 🎯 Cobertura de Pruebas
Las pruebas automatizadas se ejecutan sobre el sitio de práctica [Sauce Demo](https://www.saucedemo.com), cubriendo los siguientes escenarios:
1. **Login Exitoso:** Validación de acceso con credenciales válidas.
2. **Login Fallido (Prueba Negativa):** Validación del mensaje de error al intentar ingresar con un usuario bloqueado.
3. **Flujo de Compra E2E:** Login -> Agregar producto al carrito -> Verificar carrito -> Iniciar Checkout.

## 📂 Estructura del proyecto
- `Pages/`: Contiene las clases del Page Object Model (selectores y acciones por página).
- `UnitTest1.cs`: Contiene los casos de prueba (Tests) que consumen los Page Objects.
- `.github/workflows/`: Configuración del pipeline de CI/CD.

## 🚀 Cómo ejecutar el proyecto localmente

1. Clona este repositorio.
2. Asegúrate de tener instalado el SDK de .NET 10 y PowerShell 7.
3. Restaura las dependencias:
   ```bash
   dotnet restore