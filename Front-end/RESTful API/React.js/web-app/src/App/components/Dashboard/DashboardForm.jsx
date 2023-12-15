import React, { useEffect } from 'react'
export const DashboardForm = (props) => {

    // 핸들러에 의해 POST 요청
    const handleSubmit = async (event) => {
        event.preventDefault();  // 폼 제출 기본 동작을 막음
        const formData = new FormData(event.target);    // 폼 데이터 수집

        try{
            // 폼 데이터 전송
            const response = await fetch('http://localhost:8000/api', {
                method: 'POST',
                body: formData
            });
            if (response.ok) {
                console.log('요청 성공');
                const data = await response.json();
                console.log(data);
                // 데이터 파싱
                props.dataTransfer(data['fieldName']);
            } else {
                console.log('요청 실패');
            }

        } catch (e) {
            console.error('요청 중 오류 발생', e);
        } finally {
            // 데이터 확인
            const data = {};
            formData.forEach((value, key) => {
                data[key] = value;
            });
            console.log('폼 데이터: ', data)
        }
    }

    // 렌더링에 의해 GET요청
    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch('http://localhost:8000/api', {
                    method: "GET",
                });
                if (response.ok) {
                    console.log('요청 성공');
                    const data = await response.json();
                    console.log(data);
                } else {
                    console.error('요청 실패');
                }
            } catch (e) {
                console.error('요청 중 오류 발생', e);
            }
        }

        fetchData();
    }, []);

    return (
        <div>
            <h2>DashboardFrom</h2>
            <form
                id="form-tage"
                method="POST"
                action="http://localhost:8000/api"
                onSubmit={handleSubmit}
            >
                <div id={"form-input"}>
                    <label>
                        Input :
                        <input type={"text"} name={"input"} className={'m-1 border border-black'}/>
                    </label>
                </div>

                <div id={"form-submit"}>
                    <button type="submit" className={"px-2 border border-black rounded "}>
                        Submit
                    </button>
                </div>

            </form>
        </div>
    )
};