import { Button } from 'react-bootstrap';
import React, {useEffect} from 'react';
import {useSelector, useDispatch} from 'react-redux';
import {DeleteNote, GetNotes} from '../services/notes';
import {EditNoteModal} from './NoteModal'

// Настройки интерфесфа веб-приложения (кнопки и т.д.)
export const NotesTable = () => {
    const notes = useSelector(state => state.notesReducer.notes);
    const dispatch = useDispatch();

    useEffect(() => {
        GetNotes(dispatch);
    }, [dispatch]); 

    return <table className='table table-dark'>
        <tbody>
            {
                notes.map(n =>
                    <tr>
                        <td style={{width: '3rem'}}>
                            <EditNoteModal note={n} />
                        </td>
                        <td style={{width: '3rem'}}>
                            <Button className='btn btn-danger' onClick={() => DeleteNote(dispatch, n)}>Delete</Button>
                        </td>
                        <td style={{textAlign: 'left'}}>{n.value}</td>
                    </tr>
                )
            }
        </tbody>
    </table>
}