const mongoose = require('mongoose')
const { aiDroneSchema } = require('../models/item')

module.exports = {
    getDistinctDroneList: async (req, res) => {
        // DB 연결
        mongoose.connect('mongodb://localhost:27017/prediction_service');
        const db = mongoose.connection;

        db.on('error', console.error.bind(console, 'MongoDB connection error:'));
        db.once('open', () => {
            console.log('Connected to MongoDB');
        });

        const AiDrone = mongoose.model('ai_drone', aiDroneSchema);

        // Distinct로 device_id 조회하는 함수
        async function getDistinctDeviceIds() {
            try {
                // MongoDB에서 device_id 필드의 고유한 값들 조회
                const deviceIds = await AiDrone.distinct('device_id');
                return deviceIds;
            } catch (error) {
                console.error('Error:', error.message);
                throw error;
            } finally {
                // MongoDB 연결 종료
                mongoose.connection.close();
            }
        }

        // 위 함수를 호출하여 결과를 얻음
        try {
            const deviceIds = await getDistinctDeviceIds();
            console.log('Distinct device_ids:', deviceIds);
        } catch (error) {
            console.error('Error:', error.message);
        }
    }
};