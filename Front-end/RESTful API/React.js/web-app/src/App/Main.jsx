import React from 'react';
import { Routes, Route, BrowserRouter } from 'react-router-dom';

import { Home } from './routes/Home';
import { LoginPage } from "./components/Authentication/LoginPage";
import { RegisterPage } from "./components/Authentication/RegisterPage";
import { AppWrapper } from './routes/AppWrapper';
import { Dashboard } from './routes/Dashboard';
import { Headerboard } from "./routes/Headerboard";
import { Docs } from './routes/Docs';


export const Main = () => {
    return (
        <BrowserRouter>
            {/*  <항상 사용할 컴포넌트 />  */}
            <Routes>
                {/*  홈페이지  */}
                <Route path="/" element={<Home />} />
                <Route path="/auth/login" element={<LoginPage />} />
                <Route path="/auth/register" element={<RegisterPage />} />
                {/* 웹 어플리케이션 */}
                <Route element={<AppWrapper />}>
                    {/* Outlet 자리에 들어갈 컴포넌트 */}
                    <Route path="dashboard" element={<Dashboard />} />
                    <Route path="headerboard" element={<Headerboard />} />
                    <Route path="docs" element={<Docs />} />
                </Route>
            </Routes>
        </BrowserRouter>
    );
};
