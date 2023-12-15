# kisa-webapp

## 1. Create Project

    % mkdir kisa-webapp
    % cd kisa-webapp
    % npx create-reat-app .

    % yarn start

### 1-1. Tailwind CSS

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

#### index.css
    @import 'tailwindcss/base';
    @import 'tailwindcss/components';
    @import 'tailwindcss/utilities';

### 1-2. framer-motion

    % yarn add framer-motion

    # 컴포넌트.js
    import { motion } from "framer-motion";

### 1-3. others install dependencies

    % yarn install
