import { Outlet } from 'react-router-dom';
import {NavMenu} from "../components/NavMenu/NavMenu";

export const AppWrapper = () => {
    return (
        <div id={"app-wrapper"} className={"flex flex-col h-screen w-screen overflow-hidden"}>
            <NavMenu />
            <div className={"h-screen w-full overflow-hidden"}>
                <Outlet />
            </div>
        </div>
    );
};