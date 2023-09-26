# React.js

## 1. Create Project

### 1-1. Create APP

    % mkdir kisa-webapp
    % cd kisa-webapp
    % npx create-reat-app .

    % yarn start

### 1-2. Tailwind CSS Install

    % yarn add tailwindcss
    % npx tailwindcss init

#### tailwind.config.js
    module.exports = {
        // 템플릿 파일의 경로 설정 👀
        purge:[ './src/**/*.{js,jsx,ts,tsx}' ],
        content: [
        "./src/**/*.{js,jsx,ts,tsx}",
        ],
        theme: {
        extend: {},
        },
        plugins: [],
    }

### 1-3. framer-motion Install

    % yarn add framer-motion

#### .../Component.js
    import { motion } from "framer-motion";

    <motiom.tagName> </motiom.tagName>