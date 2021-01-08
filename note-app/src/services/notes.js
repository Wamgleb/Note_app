import { ActionCreators } from "../redux/notesReducer";
import * as axios from "axios";


// Хук, соединяем фронт и бек
const axiosInstance = axios.create({
    baseURL : "https://localhost5001/notes",
})

// Делаем запрос на получения данных с БД и отображаем ее с помощью dispatch
export const GetNotes = async (dispatch) => {
    try {
        //API call
        const { data } = await axiosInstance.get();
        dispatch(ActionCreators.setNotes(data));
    }   
    catch {
        console.log("Error!");
    }
}

// Создаем новую запись, делаем пост запрос и выводим новую запись через dispatch
export const NewNote = async (dispatch, note) => {
    try {
        //API call
        const { data } = await axiosInstance.post('', note);
        dispatch(ActionCreators.newNote(data));
    }
    catch {
        console.log("Error!");
    }
}

export const EditNote = async (dispatch, note) => {
    try {
        //API cals
        await axiosInstance.put('', note);
        dispatch(ActionCreators.editNote(note));
    }
    catch {
        console.log("Error!");
    }
}

export const DeleteNote = async (dispatch, note) => {
    try {
        // API call
        await axiosInstance.delete(`/${note.id}`);
        dispatch(ActionCreators.delteNote(note));
    }
    catch {
        console.log('Error!');
    }
}

